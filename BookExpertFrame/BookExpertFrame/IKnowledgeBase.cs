namespace BookExpertFrame
{
    public interface IKnowledgeBase
    {
        Frame getFrameByName(string nameFrame);
        AttachedProcedure FindAttachedProcedure(string nameAttachedProcedure);
    }
}
