namespace Test_RPG;

using static Health;

public class Player 
{
    private string name;
    private Health playerHealth;
    public Player(string name)
    {
        this.playerHealth = new Health(50);
        this.name = name;
        
    }
    public int getHealth()
    {
        return this.playerHealth.getHealth();
    }
    
    public void changeHealth(int amount)
    {
        this.playerHealth.changeHealth(amount);
    }
}