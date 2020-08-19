using System;

namespace WeatherAppDemo
{
    public class RootObject
    {
        internal object main;
        internal string name;
        internal object weather;

        public static implicit operator RootObject(APIManager.RootObject v)
        {
            throw new NotImplementedException();
        }
    }
}