
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Element.Reveal.DataLibrary
{
    /// <summary>
    /// Mpp 파일 업로드 파라메터 모델
    /// </summary>
    //r
    [MessageContract]
    public class MppDataDTO : /*DTOBase,*/ IDisposable
    {
        //private MppFileInfo _mppFIleInfo;

        
        public string DbInstance { get; set; }
        
        public int OwnerId { get; set; }
        
        public int ProjectObjectId { get; set; }
        
        public string ProjectObjectName { get; set; }
        
        public int ObjectId { get; set; }
        
        public string DisciplineCode { get; set; }
        
        public string LoginName { get; set; }
        
        public string UserName { get; set; }
        
        public string Password { get; set; }
        
        public string MppFileName { get; set; }
        
        public int ProjectId { get; set; }
        [MessageBodyMember(Order = 1)]
        public System.IO.Stream MppData { get; set; }

        //public MppDataDTO()
        //{
        //    //DTOStatus = (int)RowStatusNo.None;
        //}

        public void Dispose()
        {
            if (MppData != null)
            {
                //MppData.Close();
                MppData = null;
            }
        }
    }


    /// <summary>
    /// Mpp 파일 생성정보
    /// </summary>
    //public class MppFileInfo : FileSystemInfo
    //{
    //    MppDataDTO _mppData;
    //    private bool _isMakeFile = false;

    //    private string savefilepath;
    //    //public const string mppdir = "UploadMppFile";

    //    /// <summary>
    //    ///  Wcf  서버에 세팅된 파일 저장 경로값을 가져온다.
    //    /// </summary>
    //    public string savepath = System.Web.Configuration.WebConfigurationManager.AppSettings["MppSaveFilePath"].ToString();
        
    //    //public string savepath = System.IO.Path.Combine(System.Environment.CurrentDirectory, mppdir);

    //    #region Constructor
    //    public MppFileInfo(MppDataDTO mppData, bool IsForceMakeFile = false)
    //    {
    //        _mppData = mppData;
    //        //this.mppdata = mppdata;
    //        this.savefilepath = System.IO.Path.Combine(savepath, _mppData.MppFileName);

    //        if (IsForceMakeFile)
    //        {
    //            MakeMppFileFromStream();
    //        }
    //    }
    //    #endregion

    //    /// <summary>
    //    /// mpp 파일 생성 유무
    //    /// </summary>
    //    public bool IsMakeFile
    //    {
    //        get { return _isMakeFile; }
    //        set { _isMakeFile = value; }
    //    }


    //    public override string FullName
    //    {
    //        get
    //        {
    //            return this.savefilepath;
    //        }
    //    }
    //    public override string ToString()
    //    {
    //        return _mppData.ToString();
    //    }
    //    public override void Delete()
    //    {
    //        if (File.Exists(this.savefilepath))
    //        {
    //            ///파일을 삭제한다.
    //            ///파일 삭제하고 뭔가 해줘야하나?
    //            ///
    //            File.Delete(this.savefilepath);


    //        }
    //    }

    //    public override bool Exists
    //    {
    //        get
    //        {
    //            return File.Exists(this.savefilepath) ? true : false;
    //        }
    //    }

    //    public override string Name
    //    {
    //        get { return _mppData.MppFileName; }
    //    }




    //    /// <summary>
    //    /// 스트림 데이터를 파일로 저장한후 경로를 리턴한다.
    //    /// </summary>
    //    /// <returns>생성파일경로</returns>
    //    public string MakeMppFileFromStream()
    //    {
    //        try
    //        {
    //            //FileStream fs = new FileStream(savefilepath, FileMode.CreateNew, FileAccess.Write);

    //            //디렉토리가 없으면 생성한다.
    //            if (!System.IO.Directory.Exists(savepath))
    //            {
    //                System.IO.Directory.CreateDirectory(this.savepath);
    //            }

    //            //파일 생성
    //            if (!System.IO.File.Exists(savefilepath))
    //            {
    //                using (FileStream fs = System.IO.File.Create(savefilepath))
    //                {
    //                    BinaryWriter bw = new BinaryWriter(fs);

    //                    byte[] bf = new byte[65535];
    //                    int readAmount;
    //                    while ((readAmount = _mppData.MppData.Read(bf, 0, bf.Length)) > 0)
    //                    {
    //                        bw.Write(bf, 0, readAmount);
    //                    }
    //                    //bw.Close();
    //                    //fs.Close(); 
    //                }
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            _isMakeFile = true;
    //        }
    //        return savefilepath;
    //    }
    //}
}
