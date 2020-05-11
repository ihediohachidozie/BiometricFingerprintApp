﻿using System;
using System.Collections.Generic;
using System.Text;


namespace BiometricFingerprintApp
{
    public partial class FingerVerify : CaptureForm
    {
        public FingerVerify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Verificator.Verify(features, Template, ref result);
                UpdateStatus(result.FARAchieved);
                if (result.Verified)
                {
                    //MakeReport("The fingerprint was VERIFIED.");
                    Verification.confirm = true;
                    System.Windows.Forms.MessageBox.Show("The fingerprint VERIFIED");
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The fingerprint NOT VERIFIED.");
                    //MakeReport("The fingerprint was NOT VERIFIED.");
                }
                    
            }
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;


    }
}
