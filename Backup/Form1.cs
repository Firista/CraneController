using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsApplication3
{
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Int32 zerobutton;
		private System.String pathprog;
		private System.String pathformbackground1;
		private System.String pathformbackground2;
		private System.String pathCraneHelp;
		private System.Double pos_small;
		private System.Double zerodis;
		private System.Double close;
		private System.Double zero;
		private System.Double neg_small;
		private System.Double neg_big;
		private System.Double medium;
		private System.Double far;
		private System.Double neg_medium_pow;
		private System.Double zero_pow;
		private System.Double pos_medium_pow;
		private System.Double pos_high_pow;
		private System.String system;
		private System.Int32 id;
		private System.Double angle;
		private System.Double distance;
		private System.Double power;
		private System.Double pow;
		private System.Double x;
		private System.Double dis;
		private System.Double fx;
		private System.Drawing.Pen grayPen;
		private System.Drawing.SolidBrush grayBrush;
		private System.Drawing.SolidBrush yellowBrush;
		private System.Drawing.Pen blackPen;
		private System.Drawing.Graphics formGraphics;
		private System.Drawing.SolidBrush blackBrush;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
	
			pathprog=System.Environment.CurrentDirectory.ToString();
			pathprog=pathprog.Substring(0,pathprog.Length-9);
			pathformbackground1=pathprog+"formbackground1.bmp";
			this.BackgroundImage=System.Drawing.Image.FromFile(pathformbackground1);
			pathformbackground2=pathprog+"formbackground2.bmp";
			pathCraneHelp=pathprog+"CraneHelp.chm";
		
			dis=21.84;
			x=0;
		
			neg_medium_pow=-6.75;
			zero_pow=0;
			pos_medium_pow=25;
			pos_high_pow=30;

			
			formGraphics=this.CreateGraphics();
			yellowBrush = new SolidBrush(Color.Yellow);
			blackPen = new Pen(Color.Black);
			blackPen.Width=1;
			grayPen=new Pen(Color.Gray);
			grayPen.Width=1;
			grayBrush=new SolidBrush(Color.Gray);
			blackBrush = new SolidBrush(Color.Black);
			
			id=0;
			angle=0;
			distance=0;
			system="Manual";
			power=0;
			pow=0;

			zerobutton=0;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 215;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(272, 280);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "0.00";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(272, 304);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "21.84";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Enabled = false;
			this.label3.Location = new System.Drawing.Point(272, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "0.00";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(560, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Manual";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(568, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(16, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "+";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(600, 64);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "-";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(560, 96);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "R&eset";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(584, 64);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(16, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "0";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Gray;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(176, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Angle : Degree";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gray;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(176, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Distance : Yard";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Gray;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(176, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Power : KW";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(560, 128);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(64, 23);
			this.button6.TabIndex = 12;
			this.button6.Text = "&Stop";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(560, 160);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(64, 23);
			this.button7.TabIndex = 13;
			this.button7.Text = "&Fuzzy";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(560, 192);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(64, 23);
			this.button8.TabIndex = 14;
			this.button8.Text = "S&tep";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(560, 224);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(64, 23);
			this.button9.TabIndex = 15;
			this.button9.Text = "&About";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(560, 256);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(64, 23);
			this.button10.TabIndex = 16;
			this.button10.Text = "E&xit";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(560, 288);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(64, 23);
			this.button11.TabIndex = 17;
			this.button11.Text = "&Help";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(632, 373);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crane Controller";
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}	

		//Start timer in Manual Controlling
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.system="Manual";
			if(System.String.Equals(this.button1.Text,"&Manual"))power=0;
			this.timer1.Enabled=true;
			this.button1.Enabled=false;
			this.button7.Enabled=false;
			if(power<54)
				this.button2.Enabled=true;
			else
				this.button2.Enabled=false;
			if(power>-54)
				this.button3.Enabled=true;
			else
				this.button3.Enabled=false;
			this.button4.Enabled=true;
			this.button6.Enabled=true;
			this.button9.Enabled=false;
			this.button11.Enabled=false;
		}

		//timer1_Tick
		private void timer1_Tick(object sender, System.EventArgs e)
		{
				if(id>0)
				{
					// Fuzzy function
					if(System.String.Equals(system,"Fuzzy"))power=fuzzy();
					fx=52+Math.Round((21.84-Convert.ToDouble(distance))/0.0678,2);
					cleanlastimage();
			
				}
				//Simulator functions
				distance=Math.Round(sim1(),2);
				angle=sim2();

				//Time interval
				this.timer1.Interval=215-Math.Abs(Convert.ToInt32(power));
				
				this.label1.Text=angle.ToString();
				this.label2.Text=Convert.ToString(distance);
				this.label3.Text=power.ToString();
				fx=52+Math.Round((21.84-distance)/0.0678,2);
				
				//Incorrect action of crane operator damaged the container
				if(System.String.Equals(system,"Manual")&&((fx<=15)||(fx>=460)))
				{
					this.BackgroundImage=System.Drawing.Image.FromFile(pathformbackground2);
					this.timer1.Enabled=false;
					this.button2.Enabled=false;
					this.button3.Enabled=false;
					this.button4.Enabled=false;
					this.button6.Enabled=false;
				}
			
					drawnewimage();
				
					++id;
		}
		
		//Simulator function to produce variable distance
		public double sim1()
		{
				if(System.String.Equals(system,"Fuzzy")&&((power==0)&&(dis>0)))power=0.5;
				if(System.String.Equals(system,"Manual")&&(zerobutton==1))
					x=Math.Round(0.25*1000*power/this.timer1.Interval/this.timer1.Interval,2);
				else
					x=Math.Round(0.5*1000*power/this.timer1.Interval/this.timer1.Interval,2);
				dis=dis-x;
				return dis;
			
		}

		//Simulator function to produce variable angle
		public double sim2()
		{
			if(System.String.Equals(system,"Manual")==true)
			{
				if(zerobutton==1)
				{
					if(power>=pow)
					{
						if(power<=Convert.ToInt32(-pow/3))
							power=power+3;
						else
							pow=Convert.ToInt32(power);
					}

					if(power<=pow)
					{
						if(power>=Convert.ToInt32(-pow/3))
							power=power-3;
						else
							pow=Convert.ToInt32(power);
					}
					
				
		
					if((Math.Abs(Convert.ToInt32(pow))-3)==0)
					{
						power=0;
						
					
						pow=0;
						zerobutton=0;
					}
				}
			}
				return Math.Round(Convert.ToDouble(Math.Asin(-Math.Round(0.5*1000*power/this.timer1.Interval/this.timer1.Interval,2)/101)*180/Math.PI*100),0);
		}
	
		//Fuzzy function to produce optimized power
		public double fuzzy()
		{
			//Fuzzification of variables , distance and angle
			if((angle<0)&&(angle>=-90))
				pos_small=0;
			else if((angle<10)&&(angle>=0))
				pos_small=(0.1*angle);
			else if((angle<60)&&(angle>=10))
				pos_small=(-0.02*angle+1.2);
			else if((angle<=90)&&(angle>=60))
				pos_small=0;

			if((distance<-5)&&(distance>=-10))
				zerodis=0;
			else if((distance<0)&&(distance>=-5))
				zerodis=(0.2*distance+1);
			else if((distance<5)&&(distance>=0))
				zerodis=(-0.2*distance+1);
			else if((distance<=30)&&(distance>=5))
				zerodis=0;
	
			if((distance<0)&&(distance>=-10))
				close=0;
			else if((distance<5)&&(distance>=0))
				close=(0.2*distance);
			else if((distance<10)&&(distance>=5))
				close=(0.2*distance+2);
			else if((distance<=30)&&(distance>=10))
				close=0;

			if((angle>=-90)&&(angle<-10))
				zero=0;
			else if((angle<0)&&(angle>=-10))
				zero=(0.1*angle+1);
			else if((angle<10)&&(angle>=0))
				zero=(-0.1*angle+1);
			else if((angle<=90)&&(angle>=10))
				zero=0;
	
			if((angle<-60)&&(angle>=-90))
				neg_small=0;
			else if((angle<-10)&&(angle>=-60))
				neg_small=(0.02*angle+1.2);
			else if((angle<0)&&(angle>=-10))
				neg_small=(-0.1*angle);
			else if((angle<=90)&&(angle>=0))
				neg_small=0;

			if((angle<-60)&&(angle>=-90))
				neg_big=1;
			else if((angle>=-60)&&(angle<-10))
				neg_big=(-0.02*angle-0.2);
			else if((angle>=-10)&&(angle<=90))
				neg_big=0;

			if((distance<5)&&(distance>=-10))
				medium=0;
			else if((distance<10)&&(distance>=5))
				medium=(0.2*distance-1);
			else if((distance<22)&&(distance>=10))
				medium=((-1/12)*distance+(11/6));
			else if((distance<=30)&&(distance>=22))
				medium=0;
		
			if((distance<10)&&(distance>=-10))
				far=0;
			else if((distance<22)&&(distance>=10))
				far=((1/12)*distance-(5/6));
			else if((distance<=30)&&(distance>=22))
				far=1;
	
			//Defuzzification of variable , power
			return System.Math.Round(System.Math.Max(System.Math.Min(pos_small,zerodis),System.Math.Min(pos_small,close))*neg_medium_pow+System.Math.Max(System.Math.Min(zero,zerodis),System.Math.Min(zero,close))*zero_pow+System.Math.Max(System.Math.Max(System.Math.Min(neg_small,close),System.Math.Min(neg_big,medium)),System.Math.Min(zero,far))*pos_medium_pow+System.Math.Max(System.Math.Min(neg_small,medium),System.Math.Min(neg_small,far))*pos_high_pow,2);
	
		}
	
		//Increase crane motor power
		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.button3.Enabled==false)this.button3.Enabled=true;
			
			if(power<54)power=power+3;
			else this.button2.Enabled=false;
			this.button4.Enabled=true;
			zerobutton=0;
		}
		
		//Decrease crane motor power
		private void button3_Click(object sender, System.EventArgs e)
		{
			if(this.button2.Enabled==false)this.button2.Enabled=true;
		
			if(power>-54)power=power-3;
			else this.button3.Enabled=false;
			this.button4.Enabled=true;
			zerobutton=0;
		}

		//Reset and initialize the system  
		private void button5_Click(object sender, System.EventArgs e)
		{
			this.timer1.Enabled=false;
			this.label1.Text="0.00";
			this.label2.Text="21.84";
			this.label3.Text="0.00";
			this.BackgroundImage=System.Drawing.Image.FromFile(pathformbackground1);
			this.button1.Enabled=true;
			this.button1.Text="&Manual";
			this.button7.Enabled=true;
			this.button7.Text="&Fuzzy";
			this.button2.Enabled=false;
			this.button3.Enabled=false;
			this.button4.Enabled=false;
			this.button6.Enabled=false;
			this.button8.Enabled=false;
			this.button9.Enabled=true;
			this.button11.Enabled=true;
			dis=21.84;
			x=0;
			power=0;
			pow=0;
			id=0;
			angle=0;
			distance=0;
			system="Manual";
			zerobutton=0;
		}

		//Turn off the crane motor
		private void button4_Click(object sender, System.EventArgs e)
		{
			pow=power;
			
			if(power!=0)
			{
				
				if(this.button2.Enabled==false)
					this.button2.Enabled=true;
				if(this.button3.Enabled==false)
					this.button3.Enabled=true;
				zerobutton=1;
			}
		}

		//Stop the timer
		private void button6_Click(object sender, System.EventArgs e)
		{
			this.timer1.Enabled=false;
			this.button6.Enabled=false;
			if(System.String.Equals(system,"Manual")==true)
			{
				this.button1.Enabled=true;
				this.button1.Text="&Resume";
			}
			if(System.String.Equals(system,"Fuzzy")==true)
			{
				this.button7.Enabled=true;
				this.button7.Text="&Resume";
			}
			
			this.button4.Enabled=false;
			this.button2.Enabled=false;
			this.button3.Enabled=false;
			
		}

		//Start timer in Fuzzy Controlling
		private void button7_Click(object sender, System.EventArgs e)
		{
			this.system="Fuzzy";
			if(System.String.Equals(this.button7.Text,"&Fuzzy"))power=10;
			this.timer1.Enabled=true;
			this.button7.Enabled=false;
			this.button1.Enabled=false;
			this.button6.Enabled=true;
			this.button8.Enabled=true;
			this.button9.Enabled=false;
			this.button11.Enabled=false;
		}

		//Stop the timer and step forwarding
		private void button8_Click(object sender, System.EventArgs e)
		{
			this.timer1.Enabled=false;
			this.button6.Enabled=false;
			this.button7.Enabled=true;
			this.button7.Text="&Resume";
			
			fx=52+Math.Round((21.84-Convert.ToDouble(distance))/0.0678,2);
			cleanlastimage();
			power=fuzzy();
			distance=Math.Round(sim1(),2);
			angle=sim2();
			
			this.label1.Text=angle.ToString();
			this.label2.Text=Convert.ToString(distance);
			this.label3.Text=power.ToString();
			fx=52+Math.Round((21.84-distance)/0.0678,2);
			drawnewimage();
		
		}

		//About
		private void button9_Click(object sender, System.EventArgs e)
		{
			WindowsApplication3.Form2 About=new Form2();
			About.Show();
		}

		//Exit
		private void button10_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	
		//Clean last image 
		public void cleanlastimage()
		{
			formGraphics.DrawRectangle(grayPen,Convert.ToSingle(fx),19,42,16);
			formGraphics.FillRectangle(grayBrush,Convert.ToSingle(fx),19,42,16);
			formGraphics.DrawRectangle(grayPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)-24),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),48,57);
			formGraphics.FillRectangle(grayBrush,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)-24),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),48,57);
			formGraphics.DrawLine(grayPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(fx)+5,44);
			formGraphics.DrawLine(grayPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(fx)+37,44);
		}
		
		//Draw new image
		public void drawnewimage()
		{

			formGraphics.DrawRectangle(blackPen,Convert.ToSingle(fx),19,42,16);
			formGraphics.FillRectangle(blackBrush,Convert.ToSingle(fx),19,42,16);
			formGraphics.DrawRectangle(blackPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)-24),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),48,57);
			formGraphics.FillRectangle(yellowBrush,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)-24),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),48,57);
			formGraphics.DrawLine(blackPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(fx)+5,44);
			formGraphics.DrawLine(blackPen,Convert.ToSingle(fx+21+101*Math.Round(Math.Sin(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(44+101*Math.Round(Math.Cos(Convert.ToDouble(angle)*Math.PI/180),2)),Convert.ToSingle(fx)+37,44);
		}
		//Show Help
		private void button11_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Help.ShowHelp(this,pathCraneHelp);
		}

		
	}
}
