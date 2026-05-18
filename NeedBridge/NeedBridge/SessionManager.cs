namespace NeedBridge
{
    // Holds logged-in user info across all forms
    public static class SessionManager
    {
        public static int    UserId   { get; set; }
        public static string FullName { get; set; }
        public static string UserType { get; set; }

        public static void Clear()
        {
            UserId   = 0;
            FullName = string.Empty;
            UserType = string.Empty;
        }
    }
}
