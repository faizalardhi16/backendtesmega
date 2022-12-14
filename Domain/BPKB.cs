namespace Domain
{
    public class BPKB
    {
        public Guid Id { get; set; }
        public string AgreementNumber { get; set; }
        public string BPKBNumber { get; set; }
        public Guid BranchId { get; set; }
        public DateTime BPKBDate { get; set; }
        public string FakturNumber { get; set; }
        public Guid LocationId { get; set; }
        public string PoliceNo { get; set; }
        public DateTime BPKBDateIn { get; set; }
        public DateTime FakturDate { get; set; }
    }
}
