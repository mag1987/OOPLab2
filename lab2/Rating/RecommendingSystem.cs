namespace lab2
{
    public class RecommendingSystem
    {
        public void Recommend(Request request, Top top)
        {
            int maxRecommend = 5;
            int i = 0;
            request.User.Recommended.Clear();
            foreach (var item in top.Rateables)
            {
                if (i <= maxRecommend && i <= top.Rateables.Count)
                {
                    if (request.User.Dislikes.Contains(item) == false)
                    {
                        request.User.Recommended.Add(item);
                    }
                    i++;
                }
                else break;
            }
        }
    }
}
