namespace Coreficent.Utility
{
    using Coreficent.Setting;
    using System.Collections;
    using UnityEngine;

    public class Test
    {
        private static readonly string delimiter = " - ";
        private static readonly string terminator = ".";

        public static void Pause()
        {
            Time.timeScale = 0.0f;
            Warn("paused");
        }

        public static void Draw(Vector3 start, Vector3 end, Color color)
        {
            if (DebugMode.On)
            {
                UnityEngine.Debug.DrawLine(start, end, color);
            }
        }

        public static void Assert(string name, bool condition)
        {
            if (!condition)
            {
                Warn("Assert" + delimiter + "Failed" + delimiter + name);
            }
        }

        public static void Debug(params object[] message)
        {
            Warn("Debug", message);
        }

        public static void ToDo(params object[] message)
        {
            Warn("Todo", message);
        }

        public static void Log(params object[] message)
        {
            Output("Log", ConcatenateMessage(message));
        }

        public static void Warn(params object[] message)
        {
            Output("Warn", ConcatenateMessage(message));
        }

        public static void Error(params object[] message)
        {
            Output("Error", ConcatenateMessage(message));
        }

        private static string ConcatenateMessage(params object[] variables)
        {
            string buffer = "";

            foreach (object i in variables)
            {
                buffer += delimiter;

                if (i == null)
                {
                    buffer += "null";
                }
                else if (i is string)
                {
                    if (i as string == "")
                    {
                        buffer += "empty";
                    }
                    else
                    {
                        buffer += i;
                    }
                }
                else
                {
                    if (i is IEnumerable)
                    {
                        string listBuffer = "";

                        string listDelimiter = ", ";

                        listBuffer += "[";

                        IEnumerable enumerable = (i as IEnumerable);

                        foreach (var item in enumerable)
                        {
                            listBuffer += listDelimiter;
                            listBuffer += item;
                        }

                        listBuffer += "]";

                        if (listBuffer.Length != 2)
                        {
                            listBuffer = listBuffer.Remove(1, listDelimiter.Length);
                        }

                        buffer += listBuffer;
                    }
                    else
                    {
                        buffer += i;
                    }
                }
            }

            return buffer;
        }

        private static void Output(string messageType, string concatenatedMessage)
        {
            if (DebugMode.On)
            {
                switch (messageType)
                {
                    case "Error":
                        UnityEngine.Debug.LogError(messageType + concatenatedMessage + terminator);
                        break;

                    case "Warn":
                        UnityEngine.Debug.LogWarning(messageType + concatenatedMessage + terminator);
                        break;

                    case "Todo":
                        UnityEngine.Debug.Log(messageType + concatenatedMessage + terminator);
                        break;

                    default:
                        UnityEngine.Debug.Log(messageType + concatenatedMessage + terminator);
                        break;
                }
            }
        }
    }
}
