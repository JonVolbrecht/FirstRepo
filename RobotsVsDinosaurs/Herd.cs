using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {

        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("Theropod", 80, 100, 120);
            Dinosaur dinosaur2 = new Dinosaur("Sauropod", 120, 100, 80);
            Dinosaur dinosaur3 = new Dinosaur("Ornithischian", 100, 100, 100);
            // Add all three robots to the list
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);


        }
    }
}

    

