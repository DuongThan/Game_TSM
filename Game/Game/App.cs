using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Game
{
    class App
    {
        private Bird bird_;
        private Moi moi_;
        private DiemSo diem_;
        private Khung khung;

        internal Bird Bird_
        {
            get
            {
                return bird_;
            }

            set
            {
                bird_ = value;
            }
        }

        internal Moi Moi_
        {
            get
            {
                return moi_;
            }

            set
            {
                moi_ = value;
            }
        }

        public App()
        {
            bird_ = new Bird(new Diem(20, 17));
            diem_ = new DiemSo();
            moi_ = new Moi();
            khung = new Khung();
        }

        public void ShowBird()
        {
            bird_.Show();
        }
        public void ShowMoi()
        {
            moi_.Show();
        }

        public void MoiDiChuyen(int chieu)
        {
            moi_.XoaMoi();
            switch(chieu)
            {
                case 1:
                    if (moi_.Moi_Bird.Y > khung.MinPoint.Y + 1)
                        moi_.Moi_Bird.Y--;
                    break;

                case 2:
                    if (moi_.Moi_Bird.Y < khung.MaxPoint.Y - 3)
                        moi_.Moi_Bird.Y++;
                    break;

                case 3:
                    if (moi_.Moi_Bird.X > khung.MinPoint.X + 1)
                        moi_.Moi_Bird.X--;
                    break;

                case 4:
                    if (moi_.Moi_Bird.X < khung.MaxPoint.X - 3)
                        moi_.Moi_Bird.X++;
                    break;
            }
           // Thread.Sleep(10);
            ShowMoi();
        }

        public bool XuLyCham()
        {
            if (moi_.X >= bird_.Dau_Bird.X && moi_.X <= bird_.Dau_Bird.X + bird_.Dai
                && moi_.Y >= bird_.Dau_Bird.Y && moi_.Y <= bird_.Dau_Bird.Y + bird_.Rong ) 
            return true;

            return false;
        }

        public void DiChuyen(ConsoleKeyInfo infokey)
        {

            bird_.Delete();
            Thread.Sleep(1);
            switch(infokey.Key)
            {

                case ConsoleKey.UpArrow:
                    if (bird_.Dau_Bird.Y > khung.MinPoint.Y + 1) 
                    bird_.Dau_Bird.Y--;
                    break;

                case ConsoleKey.DownArrow:
                    if (bird_.Dau_Bird.Y < khung.MaxPoint.Y - 3) 
                    bird_.Dau_Bird.Y++;
                    break;

                case ConsoleKey.LeftArrow:
                    if (bird_.Dau_Bird.X > khung.MinPoint.X + 1) 
                    bird_.Dau_Bird.X--;
                    break;

                case ConsoleKey.RightArrow:
                    if (bird_.Dau_Bird.X < khung.MaxPoint.X - 3) 
                        bird_.Dau_Bird.X++;
                    break;
            }
            ShowBird();
        }

    }
}
