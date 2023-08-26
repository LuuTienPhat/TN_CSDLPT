using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int QuestionNo { get; set; }
        public string Content { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string SelectedAnswer { get; set; } = "";
        public string Answer { get; set; } = "";
    }
}
