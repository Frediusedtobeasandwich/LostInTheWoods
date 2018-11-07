using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace LostInTheWoods
{
    public partial class theWoods : Form
    {

        // Fred Hammerl
        // Nov. 7, 2018
        // This is the code for the adventure game
        int storyProgress; //this int tracks story progress
        int buttonPressNumber; //this int makes sure you can't mess up the story
        Random randGen = new Random(); //this just randomly generates a number

        public theWoods()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e) //button thing
        {
            storyLabel.Text = "Go Through The Forest?"; //starts the story
            startButton.Visible = false; //changes the visibility of the buttons
            noButton.Visible = true;
            yesButton.Visible = true;
            imageLabel.Image = LostInTheWoods.Properties.Resources.Forest; //changes the image displayed
            instuctions.Visible = false; //changes the visibility of the instructions
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (buttonPressNumber == 0) //checks to see if a button has already been pressed. if 
            {
            storyProgress = storyProgress + 2; //this will only work if the button hasn't been pressed
            progressButton.Visible = true;
            }
            else
            {
                warningLabel.Text = "Please Press Continue"; //this message shows up when you make a decision after you've already made one
            }
            buttonPressNumber++; //this adds to the int to make sure you can't add or subtract from the story
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            if (buttonPressNumber == 0) //basically the same as the yes button
            {
            storyProgress = storyProgress - 1;
            progressButton.Visible = true;
            }
            else
            {
                warningLabel.Text = "Please Press Continue"; //writes a warning
            }
            buttonPressNumber++;
            
        }

        private void progressButton_Click(object sender, EventArgs e)
        {  
            int randomStuff = randGen.Next(1, 11); //selects a random number

            switch(storyProgress) // Checks the storyProgress int and compares it to the case it corresponds with
            {
                case 0: //if the storyProgress int equals this case, it'll do what's listed below until the break
                    storyLabel.Text = "You avoid the rest of the forest and stop \nby a fast food franchise. Which?"; //changes the text displayed where the story is
                    yesButton.Visible = false; //switches buttons' visibility
                    noButton.Visible = false;
                    mcdonaldsButton.Visible = true;
                    tecobellButton.Visible = true;
                    harveysButton.Visible = true;
                    endButton.Visible = false;
                    popeyesButton.Visible = true;
                    kfcButton.Visible = true;
                    imageLabel.Image = null; //makes the image null
                    break;
                case -1:
                    storyLabel.Text = "You avoid the rest of the forest and stop \nby a fast food franchise. Which?";
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    mcdonaldsButton.Visible = true;
                    tecobellButton.Visible = true;
                    harveysButton.Visible = true;
                    endButton.Visible = false;
                    popeyesButton.Visible = true;
                    kfcButton.Visible = true;
                    imageLabel.Image = null;
                    break;
                case 100:
                    storyLabel.Text = "You order and enjoy a lovely happy meal.\nYOU WIN.";
                    mcdonaldsButton.Visible = false;
                    tecobellButton.Visible = false;
                    harveysButton.Visible = false;
                    popeyesButton.Visible = false;
                    kfcButton.Visible = false;
                    endButton.Visible = true;
                    resetButton.Visible = true;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Mcdownload; //changes the image box to the image listed
                    break;
                case 101:
                    storyLabel.Text = "You order a taco. It's okay, you guess.\nYOU WIN.";
                    mcdonaldsButton.Visible = false;
                    tecobellButton.Visible = false;
                    harveysButton.Visible = false;
                    popeyesButton.Visible = false;
                    kfcButton.Visible = false;
                    endButton.Visible = true;
                    resetButton.Visible = true;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.TecoBell;
                    break;
                case 102:
                    storyLabel.Text = "You get yourself a family \nsized bucket. That's a lot of chicken.\nYOU WIN";
                    mcdonaldsButton.Visible = false;
                    tecobellButton.Visible = false;
                    harveysButton.Visible = false;
                    popeyesButton.Visible = false;
                    kfcButton.Visible = false;
                    endButton.Visible = true;
                    resetButton.Visible = true;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.kfc;
                    break;
                case 103:
                    storyLabel.Text = "\"LOVE THAT CHICKEN FROM POPEYES\".\nYOU WIN";
                    mcdonaldsButton.Visible = false;
                    tecobellButton.Visible = false;
                    harveysButton.Visible = false;
                    popeyesButton.Visible = false;
                    kfcButton.Visible = false;
                    endButton.Visible = true;
                    resetButton.Visible = true;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.popeyes;
                    break;
                case 104:
                    storyLabel.Text = "something about burgers.\nyou win";
                    mcdonaldsButton.Visible = false;
                    tecobellButton.Visible = false;
                    harveysButton.Visible = false;
                    popeyesButton.Visible = false;
                    kfcButton.Visible = false;
                    endButton.Visible = true;
                    resetButton.Visible = true;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.BurgerKing;
                    break;
                case 2:
                    storyLabel.Text = "You find a large animal you can't identify.\nDo you want to move closer?";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Forest1;
                    break;
                case 1:
                    storyLabel.Text = "You avoid the animal. Do you want to keep exploring?";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Forest;
                    break;
                case 3:
                    storyLabel.Text = "You start feeling thirsty. Do you want to look for water?";
                    storyProgress = 50;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.pond;
                    break;
                case 49:
                    storyLabel.Text = "You die of thirst. \nYOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    yesButton.Visible = false;
                    endButton.Visible = true;
                    noButton.Visible = false;
                    break;
                case 52:
                    storyLabel.Text = "You die of thirst while looking for water. \nYOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    yesButton.Visible = false;
                    endButton.Visible = true;
                    noButton.Visible = false;
                    break;
                case 4:
                    storyLabel.Text = "You see a bear. Close to the bear is a gun. \nwhat do you do?";
                    gunButton.Visible = true;
                    runButton.Visible = true;
                    checkButton.Visible = true;
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    imageLabel.Image = LostInTheWoods.Properties.Resources.BBEAR;
                    break;
                case 80:
                    if (randomStuff <= 4) //checks the random number and if it meets the requirements to the left, it'll do what's in the brackets
                    {
                        storyLabel.Text = "The bear gets to you before you get the gun. \nDo You Want To Continue?";
                        gunButton.Visible = false;
                        runButton.Visible = false;
                        checkButton.Visible = false;
                        yesButton.Visible = true;
                        noButton.Visible = true;
                        storyProgress = 70; //sets the int storyProgress to the number
                        imageLabel.Image = LostInTheWoods.Properties.Resources.BearWithGun;
                    }
                    else //the stuff below is what happens when the requirements of the if statement above aren't met
                    {
                        storyLabel.Text = "You get the gun. \nDo You Shoot?";
                        gunButton.Visible = false;
                        runButton.Visible = false;
                        checkButton.Visible = false;
                        yesButton.Visible = true;
                        noButton.Visible = true;
                    }
                    break;
                case 71:
                    storyLabel.Text = "You get the gosh-darn heck outta there. \nContinue Through The Forest?";
                    gunButton.Visible = false;
                    runButton.Visible = false;
                    checkButton.Visible = false;
                    yesButton.Visible = true;
                    noButton.Visible = true;
                    storyProgress = 1;
                    break;
                case 74:
                    if (randomStuff < 5)
                    {
                        storyLabel.Text = "The bear hasn't noticed you and you escape. \nDo you continue to explore?";
                        gunButton.Visible = false;
                        runButton.Visible = false;
                        checkButton.Visible = false;
                        yesButton.Visible = true;
                        noButton.Visible = true;
                        storyProgress = 1;
                    }
                    else
                    {
                        storyLabel.Text = "The time it takes you to think about the question,\nThe bear has already mauled you. \nDo You Want To Continue?";
                        gunButton.Visible = false;
                        runButton.Visible = false;
                        checkButton.Visible = false;
                        yesButton.Visible = true;
                        noButton.Visible = true;
                        storyProgress = 70;
                    }
                    break;
                case 69:
                    storyLabel.Text = "You Decide To Die. YOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    yesButton.Visible = false;
                    endButton.Visible = true;
                    noButton.Visible = false;
                    break;
                case 72:
                    storyLabel.Text = "Too Bad. You've Just Been Mauled. YOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    endButton.Visible = true;
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    break;
                case 82:
                    storyLabel.Text = "The bear dies. Though it's not hunting season.\nThe fuzz already all over you.\nDo you resist arrest?";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Bear1;
                    Thread.Sleep(3000); //makes the programme wait
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Police;
                    storyProgress = 84;
                    break;
                case 79:
                    storyLabel.Text = "The bear seems friendly now.\nDo you want to pet the bear?";
                    break;
                case 81:
                    storyLabel.Text = "You reach your arm out, and then the bear mauls you. \nYOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    endButton.Visible = true;
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    break;
                case 78:
                    storyLabel.Text = "You get the heck outta there.\nDo you want to leave the forest?";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.Forest;
                    storyProgress = 1;
                    break;
                case 86:
                    storyLabel.Text = "That's another fine.\nThey tackle you to the ground.\nYou get locked up for quite some time. \nYOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    endButton.Visible = true;
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    break;
                case 83:
                    storyLabel.Text = "You go quietly.\nYou get locked up for quite some time. \nYOU LOSE";
                    imageLabel.Image = LostInTheWoods.Properties.Resources.x;
                    resetButton.Visible = true;
                    endButton.Visible = true;
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    break;
            }
            buttonPressNumber = 0; // resets the buttonPressNumber so you can make a desicions for the new question
            warningLabel.Text = ""; // gets rid of the warning
            progressButton.Visible = false;
        }

        private void mcdonaldsButton_Click(object sender, EventArgs e)
        {
            storyProgress = 100;
            progressButton.Visible = true;
        }

        private void tecobellButton_Click(object sender, EventArgs e)
        {
            storyProgress = 101;
            progressButton.Visible = true;
        }

        private void kfcButton_Click(object sender, EventArgs e)
        {
            storyProgress = 102;
            progressButton.Visible = true;
        }

        private void popeyesButton_Click(object sender, EventArgs e)
        {
            storyProgress = 103;
            progressButton.Visible = true;
        }

        private void harveysButton_Click(object sender, EventArgs e)
        {
            storyProgress = 104;
            progressButton.Visible = true;
        }

        private void gunButton_Click(object sender, EventArgs e)
        {
            storyProgress = 80;
            progressButton.Visible = true;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            storyProgress = 71;
            progressButton.Visible = true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            storyProgress = 74;
            progressButton.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e) //resets everything
        {
            storyProgress = 0;
            mcdonaldsButton.Visible = false;
            tecobellButton.Visible = false;
            harveysButton.Visible = false;
            popeyesButton.Visible = false;
            kfcButton.Visible = false;
            resetButton.Visible = false;
            startButton.Visible = true;
            yesButton.Visible = false;
            noButton.Visible = false;
            endButton.Visible = false;
            storyLabel.Text = "";
            imageLabel.Image = null;
        }
        private void endButton_Click(object sender, EventArgs e)
        {
            Close(); //ends the programme
        }
    }
}
