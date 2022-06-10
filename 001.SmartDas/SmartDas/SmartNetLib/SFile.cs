using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SmartNetLib
{
    /// <summary>
    /// 파일 클래스
    /// </summary>
    public class SFile
    {
        /// <summary>
        /// 파일 전송시 결과
        /// </summary>
        public enum TransError
        {
            /// <summary>
            /// 정상 처리
            /// </summary>
            OK,

            /// <summary>
            /// 네트워크스트림이 설정되지 않음
            /// </summary>
            NetworkStreamEmpty,

            /// <summary>
            /// 연결이 끊김
            /// </summary>
            CloseConnect,

            /// <summary>
            /// 스레드 강제 종료
            /// </summary>
            ThreadAbort,

            /// <summary>
            /// 전송 메세지 오류
            /// </summary>
            MesError,

            /// <summary>
            /// 그외의 에러
            /// </summary>
            TheOrder
        }
        private const int BUFSIZE = 4096;

        private long _fileSize;
        private FileInfo _fi;

        /// <summary>
        /// 파일 이름
        /// </summary>
        public string FileName;

        private FileStream _fs;

        /// <summary>
        /// 전송된 숫자 - 한번에 BUFSIZE 만큼 전송됨
        /// </summary>
        public int sendCount;

        /// <summary>
        /// 총 크기
        /// </summary>
        public long totalSize;

        /// <summary>
        /// 오픈한 파일 크기
        /// </summary>
        public long FileSize
        {
            get { return _fileSize; }
        }

        /// <summary>
        /// 모두 전송했는지...
        /// </summary>
        public bool isEnd
        {
            get
            {
                return (sendCount * BUFSIZE) >= _fileSize;
            }
        }
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="FilePath">파일 위치</param>
        /// <param name="totalSize">전송받을 파일 크기</param>
        public SFile(string FilePath, long totalSize)
        {
            FileName = FilePath;
            this.totalSize = totalSize;

            if (File.Exists(FileName))
            {
                _fi = new FileInfo(FileName);
                _fileSize = _fi.Length;
            }
            else
            {
                _fi = null;
                _fileSize = 0;
            }

            sendCount = (int)(_fileSize / BUFSIZE);
        }

        /// <summary>
        /// 입력받다 중단되었는지... ( 입력한 파일 크기와 현재 저장된 파일의 크기가 다르면 )
        /// </summary>
        public bool isPause
        {
            get
            {
                if (_fileSize > 0)
                    return totalSize > _fileSize;
                else
                    return false;
            }
        }

        /// <summary>
        /// 파일에 해당 바이트 배열을 쓴다.
        /// </summary>
        /// <param name="data">바이트 배열</param>
        /// <param name="bAdd">추가 할 건지 새로 쓸건지</param>
        /// <returns>성공 여부</returns>
        public bool WriteByte(Byte[] data, bool bAdd)
        {
            try
            {
                if (bAdd)
                {
                    // 추가
                    _fs = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                    sendCount++;
                }
                else
                {
                    // 신규
                    _fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                    sendCount = 1;
                }

                _fs.Write(data, 0, data.Length);
                _fs.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 파일 읽기
        /// </summary>
        /// <param name="buf">데이터를 저장할 버퍼</param>
        /// <param name="fIndex">읽을 위치 ( fIndex * BUFSIZE ) </param>
        /// <returns>읽은 바이트 수</returns>
        public int ReadByte(Byte[] buf, int fIndex)
        {
            try
            {
                int count;

                _fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                _fs.Seek(fIndex * BUFSIZE, SeekOrigin.Begin);

                count = _fs.Read(buf, 0, BUFSIZE);

                _fs.Close();

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 파일 삭제
        /// </summary>
        /// <returns>삭제 성공시</returns>
        public bool DeleteFile()
        {
            try
            {
                File.Delete(FileName);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
