namespace cvkayitvearsivleme
{
    internal class Services
    {
        public bool isNotNull(string[] items)
        {
            foreach (var item in items)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
