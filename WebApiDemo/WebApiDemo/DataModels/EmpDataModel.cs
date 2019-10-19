namespace WebApiDemo.DataModels
{
    public class EmpDataModel
    {
        /// <summary>
        /// 流水碼
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 編號
        /// </summary>
        public string PSD { get; set; }
        /// <summary>
        /// 員工名稱
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 連絡電話
        /// </summary>
        public string PHONE { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string REMARK { get; set; }
    }
}