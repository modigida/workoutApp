namespace Assignment_7.Files
{
    public static class Time
    {
        public static string Format(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
