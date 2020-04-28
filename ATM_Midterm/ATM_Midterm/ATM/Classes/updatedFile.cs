using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class updatedFile
    {
        // updatedFile class that handles writes data from currentFile and update data from customer to a new file.
        // Author: Professor Frank Friedman, with modifications by Zachary Goncalves
        private string updatedFilePath;
        private StreamWriter outputFile;   // Reference variable of type SW
        private int recordsWrittenCount;
        private List<string> recordsList = new List<string>();

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public updatedFile(string filePath)
        {
            recordsWrittenCount = 0;
            updatedFilePath = filePath;
        } // end currentFileClass 
        // Adds record to list of records 
        public void putNextRecord(string record)
        {
            recordsList.Add(record);
        }
        // Writes each record in list of reccords to updatedfile.
        public void generateFile()
        {
            try
            {
                if (File.Exists(updatedFilePath))
                {
                    File.Delete(updatedFilePath);
                }
                using (outputFile = new StreamWriter(updatedFilePath, true))
                {
                    foreach (string record in recordsList)
                    {
                        outputFile.WriteLine(record);
                        recordsWrittenCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot write file" + updatedFilePath + "Terminate Program." + ex, "Output File Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Get value of number of records read
        public int getRecordsWrittenCount()
        {
            return recordsWrittenCount;
        } // end getecordsReadCount


        // Close the input file
        public void closeFile()
        {
            outputFile.Close();
        } // end Sub


        // Rewind the input file
        public void rewindFile()
        {
            recordsWrittenCount = 0;
            outputFile.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
    } // end currentFileClass
}