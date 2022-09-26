using BaseThread.VueModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseThread.VueModeles
{
    public class ThreadVueModele : BaseVueModele
    {
        #region Attributs

        public static List<ThreadVueModele> CollClasse = new List<ThreadVueModele>();
        private bool OnCancel = false;
        private int _points=0;
        private int _points2 = 0;
        #endregion

        #region Constructeurs

        public ThreadVueModele()
        {
        }

        #endregion

        #region Getters/Setters
        public int Points
        {
            get { return _points; }
            set { SetProperty(ref _points, value); }
        }
        public int Points2
        {
            get { return _points2; }
            set { SetProperty(ref _points2, value); }
        }
        #endregion

        #region Methodes

        public void LanceThread()
        {
            Task.Run( () =>
            {

                while (OnCancel == false)
                {
                    Points++;
                    Thread.Sleep(10);
                }
            });
            Task.Run( () =>
            {

                while (OnCancel == false)
                {
                    Points2++;
                    Thread.Sleep(10);
                }
            });
        }

        #endregion
    }
}
