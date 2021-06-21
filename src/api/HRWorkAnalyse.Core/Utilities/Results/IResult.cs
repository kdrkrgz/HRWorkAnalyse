using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Core.Utilities.Results
{
    public interface IResult
    {
        bool IsSuccess {get;}
        string Message {get;}
    }
}
