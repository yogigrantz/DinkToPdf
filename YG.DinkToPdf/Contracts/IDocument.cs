namespace DinkToPdf.Contracts;

public interface IDocument : ISettings
{
   IEnumerable<IObject> GetObjects();
}
