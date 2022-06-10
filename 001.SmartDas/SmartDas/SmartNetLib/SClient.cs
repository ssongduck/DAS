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
    /// 클라이언트
    /// </summary>
    public class SClient
    {
        int iCount;

        private const int BUFSIZE = 4096;

        private TcpClient _client;
        private NetworkStream _nSt;
        private StreamWriter _sWriter;
        private StreamReader _sReader;

        private BinaryReader _bReader;
        private BinaryWriter _bWriter;

        private Hashtable _listFile;

        private Queue MessageQueue;
        private System.Windows.Forms.Timer timer;

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
            CloseClient
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

        private Thread _th;

        private bool _file;

        /// <summary>
        /// 접속할 서버의 IP
        /// </summary>
        public string ServerIP;

        /// <summary>
        /// 접속할 서버의 Port
        /// </summary>
        public int ServerPort;

        /// <summary>
        /// 자신의 IP
        /// </summary>
        public string ThisIP;

        /// <summary>
        /// 자신의 Port
        /// </summary>
        public int ThisPort;

        /// <summary>
        /// 접속되었는지를 확인한다.
        /// </summary>
        public bool isConnect
        {
            get
            {
                try
                {
                    return _client.Connected;
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 네트워크 스트림을 받아온다.
        /// </summary>
        /// <returns></returns>
        public NetworkStream GetStream()
        {
            if (isConnect)
            {
                if (_nSt != null)
                {
                    _nSt = _client.GetStream();
                }

                return _nSt;
            }

            return null;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        public SClient()
        {
            _file = false;
            iCount = 0;
            _client = new TcpClient();
            _listFile = new Hashtable();

            MessageQueue = new Queue();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="tcp"> 연결된 TcpClient </param>
        public SClient(TcpClient tcp)
        {
            _file = false;
            iCount = 0;
            _client = tcp;
            _listFile = new Hashtable();

            MessageQueue = new Queue();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
        }

        /// <summary>
        /// 연결 종료
        /// </summary>
        public void Close()
        {
            if (isConnect)
            {
                _client.Close();
            }

            if (_th != null)
            {
                _th.Abort();
            }

            MessageQueue.Clear();
            timer.Stop();
        }

        /// <summary>
        /// 소멸자
        /// </summary>
        ~SClient()
        {
            if (_th != null)
                _th.Abort();

            timer.Stop();

            MessageQueue.Clear();
        }

        /// <summary>
        /// 연결한다.
        /// </summary>
        /// <returns>성공 여부</returns>
        public bool Connect()
        {
            if (!isConnect)
            {
                try
                {
                    _client.Connect(ServerIP, ServerPort);
                }
                catch (SocketException)
                {
                    try
                    {
                        _client.Close();
                        _client.Connect(ServerIP, ServerPort);
                    }
                    catch (Exception)
                    {
                        if (iCount < 5)
                        {
                            iCount++;

                            Thread.Sleep(50);
                            return Connect();
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                    _client = new TcpClient();

                    _client.Connect(ServerIP, ServerPort);
                }
                catch (Exception)
                {
                    return false;
                }

                _nSt = _client.GetStream();
                _sReader = new StreamReader(_nSt);
                _sWriter = new StreamWriter(_nSt);

                _bReader = new BinaryReader(_nSt);
                _bWriter = new BinaryWriter(_nSt);

                _th = new Thread(new ThreadStart(ReadMessage));
                _th.Start();
                timer.Start();

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 연결한다.
        /// </summary>
        /// <param name="IP"> 서버 IP </param>
        /// <param name="port"> 서버 Port </param>
        /// <returns></returns>
        public bool Connect(String IP, int port)
        {
            ServerIP = IP;
            ServerPort = port;

            return Connect();
        }

        /// <summary>
        /// 서버에 문자열을 전송한다.
        /// </summary>
        /// <param name="mes"> 전송할 문자열 </param>
        public void SendString(string mes)
        {
            try
            {
                if (isConnect)
                {
                    if (_nSt == null)
                    {
                        _sWriter = new StreamWriter(_nSt);
                    }

                    _sWriter.Write(mes);

                    _sWriter.Flush();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// 서버에 문자열을 전송한다.
        /// 끝문자로 "\x0D"를 붙인다.
        /// </summary>
        /// <param name="mes"> 전송할 문자열 </param>
        public void SendStringD(string mes)
        {
            try
            {
                if (isConnect)
                {
                    if (_nSt == null)
                    {
                        _sWriter = new StreamWriter(_nSt);
                    }

                    _sWriter.Write(mes + "\x0D");

                    _sWriter.Flush();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        #region 메세지 받고 처리
        private string GetString(char[] str)
        {
            string s = "";
            int i = 0;

            while (str[i] != '\0')
            {
                s += str[i++];
            }

            for (i = 0; str[i] != '\0'; i++)
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

            for (i = 0; str[i] != 0; i++)
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
                                OnClose(this);
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    if (!_file)
                        break;
                }
            }

            if (!_file)
                OnClose(this);
        }

        #endregion

        #region 파일 전송
        #region 파일 업로드

        /// <summary>
        /// 파일 업로드 ... 서버 측에 파일을 보낸다.
        /// </summary>
        /// <param name="fromFile">업로드할 파일</param>
        /// <param name="toFile">저장할 파일</param>
        /// <exception cref="FileNotFoundException">파일을 찾을 수 없을 경우</exception>
        public void FileUpload(string fromFile, string toFile)
        {
            SFile s = new SFile(fromFile, 0);
            if (s.FileSize == 0)
                throw new FileNotFoundException();

            int key = AddHash(s);

            SendString("H!%F^*(*&LE|up|" + key.ToString() + "|" + s.FileSize.ToString() + "|" + toFile);
        }

        #endregion

        #region 파일 다운로드
        /// <summary>
        /// 파일 다운로드 ... 서버 측 파일을 내려 받는다.
        /// </summary>
        /// <param name="fromFile">받을 파일</param>
        /// <param name="toFile">저장할 파일</param>
        public void FileDownLoad(string fromFile, string toFile)
        {
            SFile s = new SFile(toFile, 0);

            int key = AddHash(s);

            SendString("H!%F^*(*&LE|down|" + key.ToString() + "|" + fromFile);
        }
        #endregion

        #region 파일 전송시 필요한 기능
        private int AddHash(SFile s)
        {
            int key;
            Random r = new Random(DateTime.Now.Millisecond);

            do
            {
                key = r.Next(0, 99);
            } while (_listFile.ContainsKey(key));

            _listFile.Add(key, s);

            return key;
        }
        #endregion

        #region 이벤트

        /// <summary>
        /// 메세지 처리용 아규먼트
        /// </summary>
        public class ReceiveMessageEventArg : EventArgs
        {
            private readonly string message;

            /// <summary>
            /// 전송받은 메시지가 저장된 메세지 아규먼트
            /// </summary>
            /// <param name="message"></param>
            public ReceiveMessageEventArg(string message)
            {
                this.message = message;
            }

            /// <summary>
            /// 전송받은 메세지
            /// </summary>
            public string ReceiveMessage
            {
                get { return message; }
            }
        }
        /// <summary>
        /// 연결 해제 되면 발생.
        /// </summary>
        public event ClosedClient CloseClientEvent;
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
        /// 연결 해제 되면 발생한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ClosedClient(object sender, SClient e);
        /// <summary>
        /// 전송완료시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void CompleteTransfer(SClient sender, SFile e);
        /// <summary>
        /// 전송 시작시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void StratTransfer(SClient sender, SFile e);
        /// <summary>
        /// 한 블럭 전송할 때마다 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        public delegate void ProgressTransfer(SClient sender, SFile e);
        /// <summary>
        /// 전송시 오류 발생시 발생
        /// </summary>
        /// <param name="sender">현재 파일 전송에 관여하는 SClient</param>
        /// <param name="e">현재 파일 전송과 연관 있는 SFileNet</param>
        /// <param name="err">발생한 오류</param>
        public delegate void TransferError(SClient sender, SFile e, SFile.TransError err);

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

        /// <summary>
        /// 완료 되면 file 전송 객체를 삭제하고 클라이언트 측의 메세지 이벤트 스레드를 살린다.
        /// </summary>
        /// <param name="sender"></param>
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

        private void OnClose(SClient e)
        {
            object[] oArr = { this, e };
            MesNode n = new MesNode(EventType.CloseClient, oArr);
            MessageQueue.Enqueue(n);
        }
        #endregion

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
                            StartTransferEvent((SClient)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.CompleteTransfer:
                        if (CompleteTransferEvent != null)
                            CompleteTransferEvent((SClient)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.TransferError:
                        if (TransferErrorEvent != null)
                            TransferErrorEvent((SClient)(n._argList[0]), (SFile)(n._argList[1]), (SFile.TransError)(n._argList[2]));
                        break;
                    case EventType.ProgressTransfer:
                        if (ProgressTransferEvent != null)
                            ProgressTransferEvent((SClient)(n._argList[0]), (SFile)(n._argList[1]));
                        break;
                    case EventType.ReceiveMessage:
                        if (ReceiveMessageEvent != null)
                            ReceiveMessageEvent((SClient)(n._argList[0]), (ReceiveMessageEventArg)(n._argList[1]));
                        break;
                    case EventType.CloseClient:
                        if (CloseClientEvent != null)
                        {
                            timer.Stop();
                            CloseClientEvent((SClient)(n._argList[0]), (SClient)(n._argList[1]));
                        }
                        break;
                }
            }
        }

        #endregion

        #endregion
    }
}
