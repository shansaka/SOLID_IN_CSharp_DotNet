using Liskov_Substitution_Principle;

Bird sparrow = new Sparrow();
Bird ostrich = new Ostrich();

MakeBirdFly(sparrow); // Output: Sparrow is flying...
MakeBirdFly(ostrich); // Output: Bird is flying...
return;

static void MakeBirdFly(Bird bird)
{
    bird.Fly();
}

