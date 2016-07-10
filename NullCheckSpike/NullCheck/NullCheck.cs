namespace NullCheck
{
    public class NullCheck
    {
        public bool PerformNullCheckVersion1(Person person)
        {
            if (person != null)
                if (person.Head != null)
                    if (person.Head.Nose != null)
                        return person.Head.Nose.Sniff();
            return false;
        }

        public bool PerformNullCheckVersion2(Person person)
        {
            return person?.Head?.Nose?.Sniff() ?? false;
        }
    }
}