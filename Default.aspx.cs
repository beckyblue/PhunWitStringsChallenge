using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhunWitStringsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            // 1.  Reverse name
            string name = "Becky Blue";

            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                resultLabel.Text += name[i];
            }
            */

            /*
            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            
            /*
            string[] rebelScum = names.Split(',');//seperate strin at commas
            string result = "";
            for (int i = rebelScum.Length - 1; i >= 0; i--)
            {
                result += rebelScum[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);// the -1 removes the last character of the string
            resultLabel.Text = result;
            /*

            */
            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            /*
            string[] rebelScum = names.Split(',');
                string result = "";
                for (int i = 0; i < rebelScum.Length; i++)//iterate through array
                {
                    int padLeft = (14 - rebelScum[i].Length) / 2;//identify # of asciis on left
                    string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padLeft, '*');//added temp string on left
                    result += temp.PadRight(14, '*');//temp var added
                    result += "<br />";//seperate names on different lines
                }
                resultLabel.Text = result;
            
            */

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string removeMe = "remove-me"; //set variable name
            int index = puzzle.IndexOf(removeMe); // using index and puzzle parameters
            puzzle = puzzle.Remove(index, removeMe.Length); //actual removal of "remove-me"
            puzzle = puzzle.ToLower();//lowercase all letter
            puzzle = puzzle.Remove(0, 1);//remove first letter
            puzzle = puzzle.Insert(0, "N");//replace first letter
            puzzle = puzzle.Replace('z', 't');//replace z w/ t

            resultLabel.Text = puzzle;
            
        }

    }
}