namespace InMemoryCache
{
    public static class InMemoryCache<T>
    {
        private static Dictionary<string, T> _cache = new Dictionary<string, T>();

        public static void Add(string key, T value)
        {
            if (_cache.ContainsKey(key))
                _cache[key] = value;
            else
                _cache.Add(key, value);
        }

        public static T Get(string key)
        {
            if (_cache.ContainsKey(key))
                return _cache[key];
            else
                return default(T);
        }
        public static T GetConfigurationSetting(string key, T value)
        {
            if (Get(key) == null)
            {
                Add(key, GetConfigurationFromDatabase(key, value));
            }
            return Get(key);

        }
        private static T GetConfigurationFromDatabase(string key, T value)
        {
            //CommonRepository GetConfigurationFromDatabase
            return value;
        }
        public static void Remove(string key)
        {
            if (_cache.ContainsKey(key))
                _cache.Remove(key);
        }
    }
}