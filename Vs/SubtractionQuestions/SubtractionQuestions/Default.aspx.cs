using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubtractionQuestions
{
    public partial class _Default : Page
    {
        private static int currentQuestionIndex = 0;
        private static int score = 0;
        private static int[,] questions = new int[10, 2];
        private  int[] attempts = new int[10];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateQuestions();
                DisplayQuestion();
            }
        }

        private void GenerateQuestions()
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                questions[i, 0] = rand.Next(10, 100); // First number (min: 10, max: 99)
                questions[i, 1] = rand.Next(10, 100); // Second number (min: 10, max: 99)
            }
        }

        private void DisplayQuestion()
        {
            //GenerateQuestions();
            if (currentQuestionIndex < 10)
            {
                lblQuestion.Text = $"{questions[currentQuestionIndex, 0]} - {questions[currentQuestionIndex, 1]} = ";
            }
            else
            {
                lblQuestion.Text = "Quiz completed!";
                btnSubmit.Visible = false;
                txtAnswer.Visible = false;
                btnNext.Visible = false;
                lblResult.Visible = false;

                // Determine final score
                string grade = "";
                if (score >= 90)
                    grade = "A";
                else if (score >= 80)
                    grade = "B";
                else if (score >= 70)
                    grade = "C";
                else if (score >= 60)
                    grade = "D";
                else
                    grade = "F";

                lblScore.Text = $"Final Score: {score} / 100 (Grade: {grade})";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int answer;
            if (int.TryParse(txtAnswer.Text, out answer))
            {
                if (answer == questions[currentQuestionIndex, 0] - questions[currentQuestionIndex, 1])
                {
                    // Correct answer
                    if (attempts[currentQuestionIndex] == 0)
                        score += 10;
                    else if (attempts[currentQuestionIndex] == 1)
                        score += 7;
                    else if (attempts[currentQuestionIndex] == 2)
                        score += 5;

                    lblResult.Text = "Correct!";
                }
                else
                {
                    // Incorrect answer
                    lblResult.Text = "Incorrect. Try again.";
                    attempts[currentQuestionIndex]++;
                }

                btnNext.Visible = true;
                btnSubmit.Enabled = false;
                txtAnswer.Enabled = false;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            lblResult.Text = "";
            txtAnswer.Text = "";
            btnSubmit.Enabled = true;
            txtAnswer.Enabled = true;
            btnNext.Visible = false;
            DisplayQuestion();
        }
    }
}