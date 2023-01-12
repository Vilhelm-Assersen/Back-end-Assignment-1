using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Assignment_1
{
    class Hero
    {
        private string heroClass;
        private string name;
        private string level;
        private string levelAttributes;
        private string equipment;
        private string validWeaponTypes;
        private string validArmorTypes;
        public string HeroClass { get => heroClass; set => heroClass = value; }
        public string Name { get => name; set => name = value; }
        public string Level { get => level; set => level = value; }
        public string LevelAttributes { get => levelAttributes; set => levelAttributes = value; }
        public string Equipment { get => equipment; set => equipment = value; }
        public string ValidWeaponTypes { get => validWeaponTypes; set => validWeaponTypes = value; }
        public string ValidArmorTypes { get => validArmorTypes; set => validArmorTypes = value; }

    }
}
