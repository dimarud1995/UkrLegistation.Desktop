using System.Runtime.Serialization;


namespace UkrLegistation.Desktop.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string login { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string fullName { get; set; }
        [DataMember]
        public long registrationDate { get; set; }
        [DataMember]
        public string role { get; set; }
    }
}
