using System;

namespace CountSmileys
{
    //    Given an array(arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
    //Rules for a smiling face:
    //Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
    //    A smiley face can have a nose but it does not have to.Valid characters for a nose are - or ~
    //   Every smiling face must have a smiling mouth that should be marked with either ) or D
    //No additional characters are allowed except for those mentioned.
    //Valid smiley face examples: :) :D ;-D :~)
    //Invalid smiley faces: ;( :> :} :]
    //Example
    //countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
    //countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
    //countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
    //Note
    //In case of an empty array return 0. You will not be tested with invalid input (input will always be an array).
    //Order of the face (eyes, nose, mouth) elements will always be the same.
    class Program
    {
        static void Main(string[] args)
        {
            string[] smileys = { ":D", ":~)", ";~D", ":)" };
            Console.WriteLine(CountSmileys(smileys));
        }

        public static int CountSmileys(string[] smileys)
        {
            int smileCount = 0;
            for (int i = 0; i < smileys.Length; i++)
            {
                // Console.WriteLine(smileys[i]);
                string smile = smileys[i];


                if (smile.Length == 2)
                {
                    if ((smile[0] == ':' || smile[0] == ';') && (smile[1] == 'D' || (smile[1] == ')')))
                    {
                        smileCount += 1;
                    }

                }
                else if (smile.Length == 3)
                {
                    if ((smile[0] == ':' || smile[0] == ';') && (smile[1] == '-' || (smile[1] == '~')) && (smile[2] == 'D' || (smile[2] == ')')))
                    {
                        smileCount += 1;
                    }
                }

                else
                {
                    return 0;
                }



            }
            return smileCount;
            // return 0;
        }

    }
}
