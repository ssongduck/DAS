using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Net;

namespace SmartNetLib
{
    /// <summary>
    /// 파일전송 시 메세지에 사용되는 프로토콜
    /// </summary>
    public enum SProtocol
    {
        /// <summary>
        /// 업로드 요청 명령 ( 클라이언트 측 )
        /// </summary>
        UP,

        /// <summary>
        /// 다운로드 요청 명령 ( 클라이언트 측 )
        /// </summary>
        DOWN,

        /// <summary>
        /// 시작
        /// </summary>
        START,

        /// <summary>
        /// 확인 ( 파일 보내는 쪽에서 )
        /// </summary>
        OK,

        /// <summary>
        /// 재전송 ( 파일 보내는 쪽에서 )
        /// </summary>
        RETRY,

        /// <summary>
        /// 종료 ( 파일 보내는 쪽 )
        /// </summary>
        END
    }
    /// <summary>
    /// 서버
    /// </summary>
    /// 
    public class SServer
    {
        /// <summary>
        /// 서버가 동작 중인지...
        /// </summary>
        public bool isRun;

        private Thread _th;

        private TcpListener _server;
        private List<SSocket> _listClient;

        private Queue MessageQueue;
        private System.Windows.Forms.Timer timer;
        /// <summary>
        /// 접속할 Port
        /// </summary>
        public int port;

        /// <summary>
        /// 접속시 이벤트 델리게이터
        /// </summary>
        /// <param name="sender"> 발생자 </param>
        /// <param name="e"> 이벤트 아규먼트 </param>
        public delegate void ConnectedSocket(object sender, SSocket.ESocket e);

        /// <summary>
        /// 연결되었을 때 발생하는 이벤트
        /// </summary>
        public event ConnectedSocket ConnetedSocketEvent;

        /// <summary>
        /// 연결되면 발생
        /// </summary>
        /// <param name="e"></param>
        private void OnConnect(SSocket.ESocket e)
        {
            MessageQueue.Enqueue(e);
        }

        private IPAddress GetIPAddress()
        {
            string clientIP = String.Empty;
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < ipHost.AddressList.Length; i++)
            {
                if (ipHost.AddressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ipHost.AddressList[i];
                }
            }

            return null;
        }

        /// <summary>
        /// 생성자
        /// 기본 생성자를 통해서 생성하면 PORT가 5000 번으로 열림.
        /// </summary>
        public SServer()
        {
            port = 5000;
            _server = new TcpListener(GetIPAddress(), port);
            MessageQueue = new Queue();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="port">생성할 Port</param>
        public SServer(int port)
        {
            _server = new TcpListener(GetIPAddress(), port);
            MessageQueue = new Queue();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10;
        }

        /// <summary>
        /// 소멸자
        /// </summary>
        ~SServer()
        {
            Stop();

            if (_th != null)
                _th.Abort();

            timer.Stop();
        }

        /// <summary>
        /// 접속한 소켓 리스트
        /// </summary>
        public List<SSocket> ListSocket
        {
            get { return _listClient; }
        }

        /// <summary>
        /// 서버의 IP 를 반환
        /// </summary>
        public string thisIP
        {
            get { return GetIPAddress().ToString(); }
        }

        /// <summary>
        /// 시작
        /// </summary>
        /// <returns> 성공 여부 </returns>
        public bool Start()
        {
            if (!isRun)
            {
                try
                {
                    isRun = true;
                    _listClient = new List<SSocket>();

                    _server.Start();
                    _th = new Thread(new ThreadStart(ServerListener));
                    _th.Start();

                    timer.Start();
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 접속 체크
        /// </summary>
        private void ServerListener()
        {
            while (true)
            {
                try
                {
                    TcpClient _tcp = _server.AcceptTcpClient();

                    SSocket _sSocket = new SSocket(_tcp);

                    _sSocket.AfterAccept();

                    SSocket.ESocket _eSocket = new SSocket.ESocket(_sSocket);

                    OnConnect(_eSocket);
                }
                catch (ThreadAbortException)
                {
                    return;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 리스트에 추가
        /// </summary>
        /// <param name="tcp"> 추가할 소켓 </param>
        /// <returns>추가 성공 여부</returns>
        public bool AddClient(SSocket tcp)
        {
            try
            {
                _listClient.Add(tcp);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 리스트에서 삭제
        /// </summary>
        /// <param name="tcp"> 삭제할 소켓 </param>
        /// <returns> 삭제 성공 여부 </returns>
        public bool RemoveClient(SSocket tcp)
        {
            try
            {
                _listClient.Remove(tcp);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 연결된 모든 Socket 가 있다면 끊고
        /// 정지 시킨다.
        /// </summary>
        /// <returns> 종료 성공 여부 </returns>
        public bool Stop()
        {
            if (isRun)
            {
                try
                {
                    _server.Stop();
                    _th.Abort();

                    while (_listClient.Count > 0)
                    {
                        // 각 세션의 연결을 끊고 리스트에서 삭제
                        SSocket s = _listClient[0];

                        // 선택된 세션 끊기
                        if (s.isConnect)
                            s.Close();

                        _listClient.Remove(s);
                    }

                    isRun = false;
                    timer.Stop();
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 메세지 전송
        /// </summary>
        /// <param name="s">전송할 메세지</param>
        /// <param name="target"> 전송할 대상 </param>
        public void SendMessage(String s, SSocket target)
        {
            if (target == null)
                SendAll(s);
            else
                target.SendString(s);

        }

        /// <summary>
        /// 전체에 메세지 전송
        /// </summary>
        /// <param name="s"></param>
        public void SendAll(String s)
        {
            foreach (SSocket e in _listClient)
            {
                e.SendString(s);
            }
        }

        /// <summary>
        /// 사용자 이름으로 해당 SSocket 찾아서 반환
        /// </summary>
        /// <param name="sUserID"></param>
        public SSocket getSocketForName(string sUserID)
        {
            foreach (SSocket e in _listClient)
            {
                if (e.UserName == sUserID)
                    return e;
            }

            return null;
        }

        #region 메세지 큐
        void timer_Tick(object sender, EventArgs e)
        {
            if (MessageQueue.Count > 0)
            {
                MessageQueueProc();
            }
        }

        private void MessageQueueProc()
        {
            SSocket.ESocket n = (SSocket.ESocket)MessageQueue.Dequeue();

            if (n != null)
            {
                if (ConnetedSocketEvent != null)
                {
                    n.SSocket.TimerStart();
                    ConnetedSocketEvent(this, n);
                }
            }
        }

        #endregion
    }
}
