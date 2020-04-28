
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class currentFile
    {
        // currentFile class that handles searching the user database and returning data.
        // Author: Professor Frank Friedman, with modifications by Zachary Goncalves
        private string currentFilePath;
        private System.IO.StreamReader currentFileSR;   // Reference variable of type SR
        private int recordReadCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public currentFile(string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + currentFilePath + "Terminate Program." + ex.Message,
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end currentFileClass 


        // Read a record from the current file
        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            } // end if

            return (nextRecord);
        } // end getNextRecord


        // Get value of number of records read
        public int getRecordsReadCount()
        {
            return recordReadCount;
        } // end getecordsReadCount


        // Close the input file
        public void closeFile()
        {
            currentFileSR.Close();
        } // end Sub


        // Rewind the input file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
    } // end currentFileClass
}