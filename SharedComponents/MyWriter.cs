using System;

namespace SharedComponents
{
    public class MyWriter
    {
        public bool IsHelloWorldString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("helloworld"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloWorldString()
        {
            return "Hello World!";
        }

        public bool IsHelloEarthString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("helloearth"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloEarthString()
        {
            return "Hello Earth!";
        }

        public bool IsHelloMarsString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellomars"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloMarsString()
        {
            return "Hello Mars!";
        }

        public bool IsHelloVenusString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellovenus"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloVenusString()
        {
            return "Hello Venus!";
        }

        public bool IsHelloJupiterString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellojupiter"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloJupiterString()
        {
            return "Hello Jupiter";
        }

        public bool IsHelloPlutoString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellopluto"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloPlutoString()
        {
            return "Hello Pluto!";
        }

        public bool IsHelloUranusString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellouranus"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloUranusString()
        {
            return "Hello Uranus!";
        }

        public bool IsHelloSunString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellosun"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloSunString()
        {
            return "Hello Sun!";
        }

        public bool IsHelloMercuryString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellomercury"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloMercuryString()
        {
            return "Hello Mercury!";
        }

        public bool IsHelloSaturnString(string assemblyString)
        {
            bool result = false;

            if (assemblyString.ToLower().Contains("hellosaturn"))
            {
                result = true;
            }

            return result;
        }
        public string GetHelloSaturnString()
        {
            return "Hello Saturn!";
        }

        public string GetHelloGenericWorldString()
        {
            return "Hello generic world!";
        }
    }
}
