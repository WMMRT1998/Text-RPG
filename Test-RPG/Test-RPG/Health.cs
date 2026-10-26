namespace Test_RPG;

public class Health
{
    private int maxHealth;
    private int health;
    // Creates health with a maximum of 100 and starts at full health.
    public Health()
    {
        this.maxHealth = 100;
        this.health = 100;
    }
    
    // Starts at full health with the given maximum. Throws if the maximum is below 1.
    public Health(int maxHealth)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(maxHealth, 1);
        this.maxHealth = maxHealth;
        this.health = maxHealth;
    }
    
    // Adds or subtracts capacity, keeping the maximum between 1 and int.MaxValue.
    // Lowering the maximum also caps current health; raising it does not heal.
    public void changeMaxHealth(int amount)
    {
        // Use long for the addition so large changes cannot overflow an int.
        this.maxHealth = (int)Math.Clamp((long)this.maxHealth + amount, 1, int.MaxValue);
        this.health = Math.Min(this.health, this.maxHealth);
    }
    
    // Positive amounts heal and negative amounts deal damage, staying between 0 and maxHealth.
    public void changeHealth(int amount)
    {
        // Use long for the addition before clamping to the allowed health range.
        this.health = (int)Math.Clamp((long)this.health + amount, 0, this.maxHealth);
    }
    
    // Returns the current health remaining.
    public int getHealth()
    {
        return this.health;
    }

    // Returns the amount of health this character has when full.
    public int getMaxHealth()
    {
        return this.maxHealth;
    }
}
