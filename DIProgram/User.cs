namespace DIProgram
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public override string ToString()
        {
            return "ID: " + UserID + " Name: " + UserName;
        }
    }
}
