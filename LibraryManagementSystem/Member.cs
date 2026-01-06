namespace LibrarySystem.Users
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public UserRole Role { get; set; }

        public Member(string name, int memberId, UserRole role)
        {
            Name = name;
            MemberID = memberId;
            Role = role;
        }

        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member: {Name}, ID: {MemberID}, Role: {Role}");
        }
    }
}