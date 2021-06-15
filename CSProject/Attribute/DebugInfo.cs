using System;

namespace CSProject.Attribute
{
    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Constructor |
                    AttributeTargets.Field |
                    AttributeTargets.Method |
                    AttributeTargets.Property,
        AllowMultiple = true)]
    public class DebugInfo : System.Attribute
    {
        private readonly int m_bugNo;
        private readonly string m_developer;
        private readonly string m_lastReview;
        public string message;

        public DebugInfo(int bg, string dev, string d)
        {
            this.m_bugNo = bg;
            this.m_developer = dev;
            this.m_lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return m_bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return m_developer;
            }
        }
        public string LastReview
        {
            get
            {
                return m_lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}