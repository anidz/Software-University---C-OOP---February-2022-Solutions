using Logger.Enums;
using Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public int AppendedMessages { get; protected set; }

        ILayout IAppender.Layout => throw new NotImplementedException();

        public abstract void Append(DateTime time, ReportLevel errorLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {AppendedMessages}";
        }
    }
}
