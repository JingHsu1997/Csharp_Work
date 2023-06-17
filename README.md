# Csharp_Work
### Basic functions of C#

#### Homepage
![ezgif com-video-to-gif](https://github.com/JingHsu1997/Csharp_Work/assets/134953373/9c34c46c-0700-42df-bedb-9fc1e52c3f07)  
##### Using MouseMove and MouseLeave events to create buttons effect.

```C#=
private void btnLoad_MouseMove(object sender, MouseEventArgs e)
{
btnLoad.ForeColor = Color.White;
btnLoad.BackColor = Color.Black;
}
private void btnLoad_MouseLeave(object sender, EventArgs e)
{
btnLoad.ForeColor = Color.Black;
btnLoad.BackColor = Color.White;
}
```
#### Date
![ezgif com-crop](https://github.com/JingHsu1997/Csharp_Work/assets/134953373/8f4b0210-7153-4c54-a54e-075ccd0e0509)
##### Input testbox.Text and output to Message.Box
```C#=
        private void buttonHandsome_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            string Age = txtAge.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show(
                            $"Hi,I'm {Name}.\n" +
                            $"I'm {Age} years old.\n" +
                            $"I'm {Sex},{Sign}.\n" +
                            "\n" +
                            "Finding handsome to date......"
                             );
        }
##### Hello

##### Load

##### Caculator

##### POS

##### Screen Saver

##### X O Game

##### Painter

