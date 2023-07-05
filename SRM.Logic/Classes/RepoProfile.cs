namespace SRM.Logic.Classes
{
    public class RepoProfile
    {
        public string Name { get; set; }
        public Repository Repository { get; set; } = new Repository();
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            RepoProfile other = (RepoProfile)obj;
            return Name == other.Name && RepositoryEquals(other.Repository);
        }

        private bool RepositoryEquals(Repository otherRepository)
        {
            if (Repository == null && otherRepository == null)
                return true;
            else if (Repository == null || otherRepository == null)
                return false;

            return Repository.Name == otherRepository.Name &&
                   Repository.ImagePath == otherRepository.ImagePath &&
                   Repository.IconPath == otherRepository.IconPath &&
                   Repository.ClientParams == otherRepository.ClientParams &&
                   Repository.TargetPath == otherRepository.TargetPath &&
                   ServerInfoEquals(Repository.ServerInfo, otherRepository.ServerInfo);
        }

        private bool ServerInfoEquals(ServerInfo info1, ServerInfo info2)
        {
            if (info1 == null && info2 == null)
                return true;
            else if (info1 == null || info2 == null)
                return false;

            return info1.Address == info2.Address &&
                   info1.Name == info2.Name &&
                   info1.Password == info2.Password &&
                   info1.Port == info2.Port &&
                   info1.BattleEye == info2.BattleEye;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + (Repository != null ? Repository.GetHashCode() : 0);
            return hash;
        }
    }
}
