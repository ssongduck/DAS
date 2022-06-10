using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;

namespace SmartNetLib
{
    /// <summary>
    /// 서버에서 접속한 소켓을 관리하기 위한 클래스
    /// </summary>
    public class SSocket
    {
        private const int BUFSIZE = 4096;

        private TcpClient _tcp;
        private Socket _socket;
        private NetworkStream _nSt;
        private StreamWriter _sWriter;
        private StreamReader _sReader;

        private BinaryReader _bReader;
        private BinaryWriter _bWriter;

        private Hashtable _listFile;

        private Queue MessageQueue;
        private System.Windows.Forms.Timer timer;

        private string sBuf;

        /// <summary>
        /// 소켓에서 발생할 수 있는 이벤트
        /// </summary>
        public enum EventType
        {
            /// <summary>
            /// 파일 전송 완료시 발생
            /// </summary>
            CompleteTransfer,

            /// <summary>
            /// 파일 전송을 시작할 때 발생
            /// </summary>
            StartTransfer,

            /// <summary>
            /// 파일 전송 중에 수시로 발생
            /// </summary>
            ProgressTransfer,

            /// <summary>
            /// 파일 전송 오류가 생겼을 때 발생
            /// </summary>
            TransferError,

            /// <summary>
            /// 메시지를 받았을 때 발생
            /// </summary>
            ReceiveMessage,

            /// <summary>
            /// 소켓이 닫힐 때 발생
            /// </summary>
            CloseSocket
        }

        private class MesNode
        {
            public EventType EventType;
            public object[] _argList;

            public MesNode(EventType eType, object[] argList)
            {
                EventType = eType;
                _argList = argList;
            }
        }
        /// <summary>
        /// 사용자 이름
        /// </summary>
        public string UserName;

        private bool _file;

        /// <summary>
        /// 메시지 이벤트가 작동되고 있는지...
        /// </summary>
        public bool isRun
        {
            get { return !_file; }
        }

        private Thread _th;
        /// <summary>
        /// 접속한 IP
        /// </summary>
        public string ThisIP;

        /// <summary>
        /// 접속한 Port
        /// </summary>
        public int ThisPort;

        private const int bufSize = 8192;

        /// <summary>
        /// 연결되거나 연결이 끊어진 Socket
        /// </summary>
        public class ESocket : EventArgs
        {
            private readonly SSocket _tcp;

            /// <summary>
            /// 이벤트 아규먼트 생성자
            /// </summary>
            /// <param name="tcp">소켓</param>
            public ESocket(SSocket tcp)
            {
                _tcp = tcp;
            }

            /// <summary>
            /// 소켓
            /// </summary>
            public SSocket SSocket
            {
                get { return _tcp; }
            }
        }

        /// <summary>
        /// 접속 여부
        /// </summary>
        public bool isConnect
        {
            get
            {
                try
                {
                    //Byte[] bArr = null;

                    //

                    return _tcp.Client.Connected;
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 네트워크스트림을 반환한다.
        /// </summary>
        /// <returns>네트워크 스트림</returns>
        public NetworkStream GetStream()
        {
            if (isConnect)
            {
                if (_nSt != null)
                {
                    

                    _nSt = new NetworkStream(_socket);
                }

                return _nSt;
            }

            return null;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="tcp">접속한 소켓</param>
        public SSocket(TcpClient tcp)
        {
            _tcp = tcp;
            _socket = tcp.Client;

            ThisIP = _socket.RemoteEndPoint.ToString();

            _file = false;
            _listFile = new Hashtable();

            MessageQueue = new Queue();

        }

        /// <summary>
        /// 소켓 종료
        /// </summary>
        public void Close()
        {
            if (isConnect)
            {
                _socket.Close(0);
            }

            if (_th != null)
                _th.Abort();

            timer.Stop();
            timer.Dispose();

            MessageQueue.Clear();
        }

        /// <summary>
        /// 소멸자
        /// </summary>
        ~SSocket()
        {
            if (_th != null)
                _th.Abort();

            timer.Stop();
            timer.Dispose();

            MessageQueue.Clear();
        }

        /// <summary>
        /// 타이머를 시작한다.
        /// </summary>
        public void TimerStart()
        {
            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 10;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Enabled = true;
            }

            timer.Start();
        }

        /// <summary>
        /// 접속된 이후 네트워크 스트림, 메세지 처리기 동작시킴
        /// </summary>
        public void AfterAccept()
        {
            _nSt = new NetworkStream(_socket);
            _sReader = new StreamReader(_nSt);
            _sWriter = new StreamWriter(_nSt);

            _th = new Thread(new ThreadStart(ReadMessage));
            _th.Start();
        }

        /// <summary>
        /// 소켓에 연결된 대상에 메세지를 전송한다.
        /// </summary>
        /// <param name="mes"></param>
        /// <exception cref="IOException">파일 전송 중일 때 발생</exception>
        public void SendString(string mes)
        {
            try
            {
                if (isConnect)
                {
                    if (_file)
                    {
                        throw new IOException("현재 파일 전송 중입니다.");
                    }

                    if (_nSt == null)
                    {
                        _sWriter = new StreamWriter(_nSt);
                    }

                    _sWriter.Write(mes);

                    _sWriter.Flush();
                }
            }
            catch (IOException e)
            {
                throw e;
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// 소켓에 연결된 대상에 메세지를 전송한다.
        /// 끝문자로 "\x0D"를 붙인다.
        /// </summary>
        /// <param name="mes"></param>
        /// <exception cref="IOException">파일 전송 중일 때 발생</exception>
        public void SendStringD(string mes)
        {
            try
            {
                if (isConnect)
                {
                    if (_file)
                    {
                        throw new IOException("현재 파일 전송 중입니다.");
                    }

                    if (_nSt == null)
                    {
                        _sWriter = new StreamWriter(_nSt);
                    }

                    _sWriter.Write(mes + "\x0D");

                    _sWriter.Flush();
                }
            }
            catch (IOException e)
            {
                throw e;
            }
            catch (Exception)
            {
                return;
            }
        }

        #region 메세지 받고 처리
        /// <summary>
        /// 메시지 아규먼트
        /// </summary>
        public class ReceiveMessageEventArg : EventArgs
        {
            private readonly string message;

            /// <summary>
            /// 생성자
            /// </summary>
            /// <param name="message"> 전송받은 메세지 </param>
            public ReceiveMessageEventArg(string message)
            {
                this.message = message;
            }

            /// <summary>
            /// 전송받은 메세지
            /// </summary>
            public string receiveMessage
            {
                get { return message; }
            }
        }

        private string GetString(char[] str)
        {
            string s = "";
            int i = 0;

            while (str[i] != '\0')
            {
                s += str[i++];
            }

            for (i = 0; str[i] != '\0' ; i++)
            {
                str[i] = '\0';
            }

            return s;
        }

        private string GetString(byte[] str)
        {
            string s = "";
            int i = 0;

            while (str[i] != 0)
            {
                s += (char)str[i++];
            }

            for (i = 0; str[i] != 0 ; i++)
            {
                str[i] = 0;
            }

            return s;
        }

        /// <summary>
        /// 이벤트 발생 함수
        /// </summary>
        private void ReadMessage()
        {
            byte[] data = new byte[100];
            string mes = "";

            while (true)
            {
                try
                {
                    if (!_file)
                    {
                        if (_nSt.Read(data, 0, 100) != 0)
                        {
                            mes += GetString(data);

                            if (mes.EndsWith("\x0D"))
                            {
                                ReceiveMessageEventArg e = new ReceiveMessageEventArg(mes);
                                OnReceiveMessageEvent(e);

                                mes = "";
                            }
                        }
                        else
                        {
                            if (!_file)
                                OnClose(new ESocket(this));
                            throw new Exception();
                        }
                    }
                }
                catch (Exception) { break; }
            }

            if (!_file)
                OnClose(new ESocket(this));
        }

        private int AddHash(SFile s)
        {
            int key;
            Random r = new Random(DateTime.Now.Millisecond);

            do
            {
                key = r.Next(1, 1000);
            } while (_listFile.ContainsKey(key));

            _listFile.Add(key, s);

            return key;
        }

        /// <summary>
        /// 파일 전송중이면 true 로 설정해야 함.
        /// </summary>
        public bool bFileTransfer
        {
            get { return _file; }
            set { _file = value; }
        }

        #endregion

        #region 파일 전송 이벤트

        /// <summary>
        /// 전송완료시 발생
        /// </summary>
        public event CompleteTransfer CompleteTransferEvent;
        /// <summary>
        /// 전송 시작시 발생
        /// </summary>
        public event StratTransfer StartTransferEvent;
        /// <summary>
        /// 한 블럭 전송할 때마다 발생
        /// </summary>
        public event ProgressTransfer ProgressTransferEvent;
        /// <summary>
        /// 전송 중 오류 발생시 발생
        /// </summary>
        public event TransferError TransferErrorEvent;
        /// <summary>
        /// 메세지를 전송받으면 발생
        /// </summary>
        public event ReceiveMessage ReceiveMessageEvent;
        /// <summary>
        /// 소켓이 닫히면 발생
        /// </summary>
        public event ClosedSocket CloseSocketEvent;

        /// <summary>
        /// 소켓이 닫히면 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ClosedSocket(object sender, ESocket e);
        /// <summary>
        /// 전송완료시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void CompleteTransfer(SSocket sender, SFile e);
        /// <summary>
        /// 전송 시작시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void StratTransfer(SSocket sender, SFile e);
        /// <summary>
        /// 한 블럭 전송할 때마다 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void ProgressTransfer(SSocket sender, SFile e);
        /// <summary>
        /// 전송시 오류 발생시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        /// <param name="err">발생한 오류</param>
        public delegate void TransferError(SSocket sender, SFile e, SFile.TransError err);

        /// <summary>
        /// 메세지 전송용 대리자
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ReceiveMessage(object sender, ReceiveMessageEventArg e);

        /// <summary>
        /// 오류가 발생하면 file 전송 객체를 삭제하고 클라이언트 측 메세지 이벤트 스레드를 살린다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="err"></param>
        void OnTransferError(SFile sender, SFile.TransError err)
        {
            object[] oArr = { this, sender, err };
            MesNode n = new MesNode(EventType.TransferError, oArr);
            MessageQueue.Enqueue(n);
        }

        void OnCompleteTransfer(SFile sender)
        {
            object[] oArr = { this, sender };
            MesNode n = new MesNode(EventType.CompleteTransfer, oArr);
            MessageQueue.Enqueue(n);
        }

        void OnProgressTransfer(SFile sender)
        {
            object[] oArr = { this, sender };
            MesNode n = new MesNode(EventType.ProgressTransfer, oArr);
            MessageQueue.Enqueue(n);
        }

        void OnStartTransfer(SFile sender)
        {
            object[] oArr = { this, sender };
            MesNode n = new MesNode(EventType.StartTransfer, oArr);
            MessageQueue.Enqueue(n);
        }

        private void OnReceiveMessageEvent(ReceiveMessageEventArg e)
        {
            object[] oArr = { this, e };
            MesNode n = new MesNode(EventType.ReceiveMessage, oArr);
            MessageQueue.Enqueue(n);
        }

        private void OnClose(ESocket e)
        {
            object[] oArr = { this, e };
            MesNode n = new MesNode(EventType.CloseSocket, oArr);
            MessageQueue.Enqueue(n);
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
            MesNode n = (MesNode)MessageQueue.Dequeue();

            if (n != null)
            {
                switch (n.EventType)
                {
                    case EventType.StartTransfer:
                        if (StartTransferEvent != null)
                            StartTransferEvent((SSocket)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.CompleteTransfer:
                        if (CompleteTransferEvent != null)
                            CompleteTransferEvent((SSocket)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.TransferError:
                        if (TransferErrorEvent != null)
                            TransferErrorEvent((SSocket)(n._argList[0]), (SFile)(n._argList[1]), (SFile.TransError)(n._argList[2]));
                        break;
                    case EventType.ProgressTransfer:
                        if (ProgressTransferEvent != null)
                            ProgressTransferEvent((SSocket)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.ReceiveMessage:
                        if (ReceiveMessageEvent != null)
                            ReceiveMessageEvent((SSocket)(n._argList[0]), (ReceiveMessageEventArg)(n._argList[1]));
                        break;
                    case EventType.CloseSocket:
                        if (CloseSocketEvent != null)
                        {
                            timer.Stop();
                            CloseSocketEvent((SSocket)(n._argList[0]), (ESocket)(n._argList[1]));
                        }
                        break;

                }
            }
        }
        #endregion

        #endregion
    }
}
