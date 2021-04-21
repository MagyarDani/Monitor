
namespace Monitor1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1_Hardware = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar_Core4Load = new System.Windows.Forms.ProgressBar();
            this.progressBar_Core3Load = new System.Windows.Forms.ProgressBar();
            this.progressBar_Core2Load = new System.Windows.Forms.ProgressBar();
            this.progressBar_Core1Load = new System.Windows.Forms.ProgressBar();
            this.progressBar_TotalLoad = new System.Windows.Forms.ProgressBar();
            this.label_core4Load = new System.Windows.Forms.Label();
            this.label_totalLoad = new System.Windows.Forms.Label();
            this.label_core3Load = new System.Windows.Forms.Label();
            this.label_core2Load = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_core1Load = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_cpuTemp = new System.Windows.Forms.Label();
            this.progressBar_cpuTemp = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM = new System.Windows.Forms.GroupBox();
            this.label_RAM = new System.Windows.Forms.Label();
            this.progressBar_RAM = new System.Windows.Forms.ProgressBar();
            this.label_Memory = new System.Windows.Forms.Label();
            this.label_Disk = new System.Windows.Forms.Label();
            this.label1_NVIDIA = new System.Windows.Forms.Label();
            this.GPU = new System.Windows.Forms.GroupBox();
            this.progressBar_GPU = new System.Windows.Forms.ProgressBar();
            this.label1_GPU = new System.Windows.Forms.Label();
            this.label1_RAMGB = new System.Windows.Forms.Label();
            this.label_mb = new System.Windows.Forms.Label();
            this.label_OS = new System.Windows.Forms.Label();
            this.label_GPUGB = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RAM.SuspendLayout();
            this.GPU.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_Hardware
            // 
            this.label1_Hardware.AutoSize = true;
            this.label1_Hardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Hardware.Location = new System.Drawing.Point(6, 82);
            this.label1_Hardware.Name = "label1_Hardware";
            this.label1_Hardware.Size = new System.Drawing.Size(98, 20);
            this.label1_Hardware.TabIndex = 0;
            this.label1_Hardware.Text = "Processzor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teljes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_Core4Load);
            this.groupBox1.Controls.Add(this.progressBar_Core3Load);
            this.groupBox1.Controls.Add(this.progressBar_Core2Load);
            this.groupBox1.Controls.Add(this.progressBar_Core1Load);
            this.groupBox1.Controls.Add(this.progressBar_TotalLoad);
            this.groupBox1.Controls.Add(this.label_core4Load);
            this.groupBox1.Controls.Add(this.label_totalLoad);
            this.groupBox1.Controls.Add(this.label_core3Load);
            this.groupBox1.Controls.Add(this.label_core2Load);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_core1Load);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // progressBar_Core4Load
            // 
            this.progressBar_Core4Load.Location = new System.Drawing.Point(57, 118);
            this.progressBar_Core4Load.Name = "progressBar_Core4Load";
            this.progressBar_Core4Load.Size = new System.Drawing.Size(282, 13);
            this.progressBar_Core4Load.TabIndex = 12;
            // 
            // progressBar_Core3Load
            // 
            this.progressBar_Core3Load.Location = new System.Drawing.Point(57, 94);
            this.progressBar_Core3Load.Name = "progressBar_Core3Load";
            this.progressBar_Core3Load.Size = new System.Drawing.Size(282, 13);
            this.progressBar_Core3Load.TabIndex = 11;
            // 
            // progressBar_Core2Load
            // 
            this.progressBar_Core2Load.Location = new System.Drawing.Point(57, 71);
            this.progressBar_Core2Load.Name = "progressBar_Core2Load";
            this.progressBar_Core2Load.Size = new System.Drawing.Size(282, 13);
            this.progressBar_Core2Load.TabIndex = 10;
            // 
            // progressBar_Core1Load
            // 
            this.progressBar_Core1Load.Location = new System.Drawing.Point(57, 50);
            this.progressBar_Core1Load.Name = "progressBar_Core1Load";
            this.progressBar_Core1Load.Size = new System.Drawing.Size(282, 13);
            this.progressBar_Core1Load.TabIndex = 9;
            // 
            // progressBar_TotalLoad
            // 
            this.progressBar_TotalLoad.Location = new System.Drawing.Point(57, 27);
            this.progressBar_TotalLoad.Name = "progressBar_TotalLoad";
            this.progressBar_TotalLoad.Size = new System.Drawing.Size(282, 13);
            this.progressBar_TotalLoad.TabIndex = 8;
            // 
            // label_core4Load
            // 
            this.label_core4Load.AutoSize = true;
            this.label_core4Load.Location = new System.Drawing.Point(345, 118);
            this.label_core4Load.Name = "label_core4Load";
            this.label_core4Load.Size = new System.Drawing.Size(32, 13);
            this.label_core4Load.TabIndex = 7;
            this.label_core4Load.Text = "... %";
            // 
            // label_totalLoad
            // 
            this.label_totalLoad.AutoSize = true;
            this.label_totalLoad.Location = new System.Drawing.Point(345, 26);
            this.label_totalLoad.Name = "label_totalLoad";
            this.label_totalLoad.Size = new System.Drawing.Size(32, 13);
            this.label_totalLoad.TabIndex = 3;
            this.label_totalLoad.Text = "... %";
            // 
            // label_core3Load
            // 
            this.label_core3Load.AutoSize = true;
            this.label_core3Load.Location = new System.Drawing.Point(345, 94);
            this.label_core3Load.Name = "label_core3Load";
            this.label_core3Load.Size = new System.Drawing.Size(32, 13);
            this.label_core3Load.TabIndex = 5;
            this.label_core3Load.Text = "... %";
            // 
            // label_core2Load
            // 
            this.label_core2Load.AutoSize = true;
            this.label_core2Load.Location = new System.Drawing.Point(345, 72);
            this.label_core2Load.Name = "label_core2Load";
            this.label_core2Load.Size = new System.Drawing.Size(32, 13);
            this.label_core2Load.TabIndex = 6;
            this.label_core2Load.Text = "... %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Core #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Core #3";
            // 
            // label_core1Load
            // 
            this.label_core1Load.AutoSize = true;
            this.label_core1Load.Location = new System.Drawing.Point(345, 50);
            this.label_core1Load.Name = "label_core1Load";
            this.label_core1Load.Size = new System.Drawing.Size(32, 13);
            this.label_core1Load.TabIndex = 4;
            this.label_core1Load.Text = "... %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Core #4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Core #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_cpuTemp);
            this.groupBox2.Controls.Add(this.progressBar_cpuTemp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(6, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Hőmérséklet";
            // 
            // label_cpuTemp
            // 
            this.label_cpuTemp.AutoSize = true;
            this.label_cpuTemp.Location = new System.Drawing.Point(345, 21);
            this.label_cpuTemp.Name = "label_cpuTemp";
            this.label_cpuTemp.Size = new System.Drawing.Size(31, 13);
            this.label_cpuTemp.TabIndex = 14;
            this.label_cpuTemp.Text = "... C";
            // 
            // progressBar_cpuTemp
            // 
            this.progressBar_cpuTemp.Location = new System.Drawing.Point(57, 21);
            this.progressBar_cpuTemp.Name = "progressBar_cpuTemp";
            this.progressBar_cpuTemp.Size = new System.Drawing.Size(282, 13);
            this.progressBar_cpuTemp.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAM
            // 
            this.RAM.Controls.Add(this.label1_RAMGB);
            this.RAM.Controls.Add(this.label_RAM);
            this.RAM.Controls.Add(this.progressBar_RAM);
            this.RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RAM.Location = new System.Drawing.Point(6, 315);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(422, 68);
            this.RAM.TabIndex = 4;
            this.RAM.TabStop = false;
            this.RAM.Text = "RAM";
            // 
            // label_RAM
            // 
            this.label_RAM.AutoSize = true;
            this.label_RAM.Location = new System.Drawing.Point(346, 19);
            this.label_RAM.Name = "label_RAM";
            this.label_RAM.Size = new System.Drawing.Size(32, 13);
            this.label_RAM.TabIndex = 15;
            this.label_RAM.Text = "... %";
            // 
            // progressBar_RAM
            // 
            this.progressBar_RAM.Location = new System.Drawing.Point(57, 19);
            this.progressBar_RAM.Name = "progressBar_RAM";
            this.progressBar_RAM.Size = new System.Drawing.Size(282, 13);
            this.progressBar_RAM.TabIndex = 14;
            // 
            // label_Memory
            // 
            this.label_Memory.AutoSize = true;
            this.label_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Memory.Location = new System.Drawing.Point(6, 106);
            this.label_Memory.Name = "label_Memory";
            this.label_Memory.Size = new System.Drawing.Size(77, 20);
            this.label_Memory.TabIndex = 5;
            this.label_Memory.Text = "Memória";
            // 
            // label_Disk
            // 
            this.label_Disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Disk.Location = new System.Drawing.Point(6, 160);
            this.label_Disk.Name = "label_Disk";
            this.label_Disk.Size = new System.Drawing.Size(388, 94);
            this.label_Disk.TabIndex = 6;
            this.label_Disk.Text = "Megjatók";
            // 
            // label1_NVIDIA
            // 
            this.label1_NVIDIA.AutoSize = true;
            this.label1_NVIDIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_NVIDIA.Location = new System.Drawing.Point(6, 128);
            this.label1_NVIDIA.Name = "label1_NVIDIA";
            this.label1_NVIDIA.Size = new System.Drawing.Size(104, 20);
            this.label1_NVIDIA.TabIndex = 7;
            this.label1_NVIDIA.Text = "Videókártya";
            // 
            // GPU
            // 
            this.GPU.Controls.Add(this.label_GPUGB);
            this.GPU.Controls.Add(this.label1_GPU);
            this.GPU.Controls.Add(this.progressBar_GPU);
            this.GPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPU.Location = new System.Drawing.Point(6, 389);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(421, 83);
            this.GPU.TabIndex = 8;
            this.GPU.TabStop = false;
            this.GPU.Text = "Videókártya";
            // 
            // progressBar_GPU
            // 
            this.progressBar_GPU.Location = new System.Drawing.Point(57, 22);
            this.progressBar_GPU.Name = "progressBar_GPU";
            this.progressBar_GPU.Size = new System.Drawing.Size(282, 13);
            this.progressBar_GPU.TabIndex = 15;
            // 
            // label1_GPU
            // 
            this.label1_GPU.AutoSize = true;
            this.label1_GPU.Location = new System.Drawing.Point(347, 22);
            this.label1_GPU.Name = "label1_GPU";
            this.label1_GPU.Size = new System.Drawing.Size(31, 13);
            this.label1_GPU.TabIndex = 16;
            this.label1_GPU.Text = "... C";
            // 
            // label1_RAMGB
            // 
            this.label1_RAMGB.AutoSize = true;
            this.label1_RAMGB.Location = new System.Drawing.Point(6, 43);
            this.label1_RAMGB.Name = "label1_RAMGB";
            this.label1_RAMGB.Size = new System.Drawing.Size(97, 13);
            this.label1_RAMGB.TabIndex = 16;
            this.label1_RAMGB.Text = "Összes memória";
            // 
            // label_mb
            // 
            this.label_mb.AutoSize = true;
            this.label_mb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mb.Location = new System.Drawing.Point(1, 51);
            this.label_mb.Name = "label_mb";
            this.label_mb.Size = new System.Drawing.Size(69, 20);
            this.label_mb.TabIndex = 9;
            this.label_mb.Text = "Alaplap";
            // 
            // label_OS
            // 
            this.label_OS.AutoSize = true;
            this.label_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_OS.Location = new System.Drawing.Point(1, 217);
            this.label_OS.Name = "label_OS";
            this.label_OS.Size = new System.Drawing.Size(172, 20);
            this.label_OS.TabIndex = 10;
            this.label_OS.Text = "Operációs Rendszer";
            // 
            // label_GPUGB
            // 
            this.label_GPUGB.AutoSize = true;
            this.label_GPUGB.Location = new System.Drawing.Point(9, 55);
            this.label_GPUGB.Name = "label_GPUGB";
            this.label_GPUGB.Size = new System.Drawing.Size(91, 13);
            this.label_GPUGB.TabIndex = 17;
            this.label_GPUGB.Text = "Teljes memória";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(941, 68);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(527, 511);
            this.listbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(937, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "PROGRAMOK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_OS);
            this.groupBox3.Controls.Add(this.label_mb);
            this.groupBox3.Controls.Add(this.label1_NVIDIA);
            this.groupBox3.Controls.Add(this.label_Memory);
            this.groupBox3.Controls.Add(this.label1_Hardware);
            this.groupBox3.Controls.Add(this.label_Disk);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 407);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A számítógép specifikációi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GPU);
            this.groupBox4.Controls.Add(this.RAM);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(471, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 507);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Használat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 608);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RAM.ResumeLayout(false);
            this.RAM.PerformLayout();
            this.GPU.ResumeLayout(false);
            this.GPU.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_Hardware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar_Core4Load;
        private System.Windows.Forms.ProgressBar progressBar_Core3Load;
        private System.Windows.Forms.ProgressBar progressBar_Core2Load;
        private System.Windows.Forms.ProgressBar progressBar_Core1Load;
        private System.Windows.Forms.ProgressBar progressBar_TotalLoad;
        private System.Windows.Forms.Label label_core4Load;
        private System.Windows.Forms.Label label_totalLoad;
        private System.Windows.Forms.Label label_core3Load;
        private System.Windows.Forms.Label label_core2Load;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_core1Load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_cpuTemp;
        private System.Windows.Forms.ProgressBar progressBar_cpuTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox RAM;
        private System.Windows.Forms.ProgressBar progressBar_RAM;
        private System.Windows.Forms.Label label_RAM;
        private System.Windows.Forms.Label label_Memory;
        private System.Windows.Forms.Label label_Disk;
        private System.Windows.Forms.Label label1_NVIDIA;
        private System.Windows.Forms.GroupBox GPU;
        private System.Windows.Forms.Label label1_GPU;
        private System.Windows.Forms.ProgressBar progressBar_GPU;
        private System.Windows.Forms.Label label1_RAMGB;
        private System.Windows.Forms.Label label_mb;
        private System.Windows.Forms.Label label_OS;
        private System.Windows.Forms.Label label_GPUGB;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

