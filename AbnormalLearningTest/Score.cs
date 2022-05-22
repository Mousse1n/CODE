using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbnormalLearningTest
{
    public class Score
    {
        private double _score;
        public Score(double score)
        {
            _score = score;
        }

        public ScoreGrade Transfer(/*double score*/)
        {
            if (_score > 100 || _score < 0)
            {
                throw new ArgumentOutOfRangeException($"输入的{ _score}超出范围");

            }
            if (_score > 80)
            {
                Console.WriteLine("");
                return ScoreGrade.Execllent;
            }
            else if (_score > 60)
            {
                return ScoreGrade.Passed;
            }
            else
            {
                return ScoreGrade.Failed;
            }


        }

    }
    public enum ScoreGrade
    {
        Execllent,
        Passed,
        Failed

    }
}
