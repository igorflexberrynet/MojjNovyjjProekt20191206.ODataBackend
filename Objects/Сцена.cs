﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Mojj_novyjj_proekt_20191206
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сцена.
    /// </summary>
    //  *** Start programmer edit section *** (Сцена CustomAttributes)

    //  *** End programmer edit section *** (Сцена CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СценаE", new string[] {
            "Площадь as \'Площадь\'",
            "РаботникСцены as \'Работник сцены\'",
            "РаботникСцены.ФИО as \'ФИО\'"})]
    [View("СценаL", new string[] {
            "Площадь as \'Площадь\'",
            "РаботникСцены.ФИО as \'ФИО\'"})]
    public class Сцена : ICSSoft.STORMNET.DataObject
    {
        
        private int fПлощадь;
        
        private IIS.Mojj_novyjj_proekt_20191206.РаботникСцены fРаботникСцены;
        
        //  *** Start programmer edit section *** (Сцена CustomMembers)

        //  *** End programmer edit section *** (Сцена CustomMembers)

        
        /// <summary>
        /// Площадь.
        /// </summary>
        //  *** Start programmer edit section *** (Сцена.Площадь CustomAttributes)

        //  *** End programmer edit section *** (Сцена.Площадь CustomAttributes)
        public virtual int Площадь
        {
            get
            {
                //  *** Start programmer edit section *** (Сцена.Площадь Get start)

                //  *** End programmer edit section *** (Сцена.Площадь Get start)
                int result = this.fПлощадь;
                //  *** Start programmer edit section *** (Сцена.Площадь Get end)

                //  *** End programmer edit section *** (Сцена.Площадь Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Сцена.Площадь Set start)

                //  *** End programmer edit section *** (Сцена.Площадь Set start)
                this.fПлощадь = value;
                //  *** Start programmer edit section *** (Сцена.Площадь Set end)

                //  *** End programmer edit section *** (Сцена.Площадь Set end)
            }
        }
        
        /// <summary>
        /// Сцена.
        /// </summary>
        //  *** Start programmer edit section *** (Сцена.РаботникСцены CustomAttributes)

        //  *** End programmer edit section *** (Сцена.РаботникСцены CustomAttributes)
        public virtual IIS.Mojj_novyjj_proekt_20191206.РаботникСцены РаботникСцены
        {
            get
            {
                //  *** Start programmer edit section *** (Сцена.РаботникСцены Get start)

                //  *** End programmer edit section *** (Сцена.РаботникСцены Get start)
                IIS.Mojj_novyjj_proekt_20191206.РаботникСцены result = this.fРаботникСцены;
                //  *** Start programmer edit section *** (Сцена.РаботникСцены Get end)

                //  *** End programmer edit section *** (Сцена.РаботникСцены Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Сцена.РаботникСцены Set start)

                //  *** End programmer edit section *** (Сцена.РаботникСцены Set start)
                this.fРаботникСцены = value;
                //  *** Start programmer edit section *** (Сцена.РаботникСцены Set end)

                //  *** End programmer edit section *** (Сцена.РаботникСцены Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СценаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СценаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СценаE", typeof(IIS.Mojj_novyjj_proekt_20191206.Сцена));
                }
            }
            
            /// <summary>
            /// "СценаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СценаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СценаL", typeof(IIS.Mojj_novyjj_proekt_20191206.Сцена));
                }
            }
        }
    }
}
