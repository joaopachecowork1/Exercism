class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
         return 40;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int value){
         return 40-value;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public  int PreparationTimeInMinutes(int value){
        return value*2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int ovenTime){
         return 2*numberOfLayers + ovenTime;
    }
}
