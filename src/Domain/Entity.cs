namespace Domain;

public class Entity
{
    public int Id { get; protected set; }
	public DateTime CreatedOn { get; }
	public DateTime UpdatedOn { get; protected set; }

	protected Entity()
	{
		
	}
	protected Entity(int id, DateTime createdOn, DateTime updatedOn)
	{
		Id = id;
		CreatedOn = createdOn;
		UpdatedOn = updatedOn;
	}

	public override bool Equals(object obj)
	{
		if (obj is not Entity other)
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		if (Id.Equals(default) || other.Id.Equals(Id))
		{
			return false;
		}

        return Id.Equals(other.Id);
    }

	public static bool operator == (Entity a, Entity b)
	{
		if (a is null && b is null)
		{
			return true;
		}

		if (a is null || b is null)
		{
			return false;
		}

		return a.Equals(b);
	}

	public static bool operator != (Entity a, Entity b)
	{
		return !(a == b);
	}

	public override int GetHashCode()
	{
		return (this.ToString() + Id).GetHashCode();
	}
}
