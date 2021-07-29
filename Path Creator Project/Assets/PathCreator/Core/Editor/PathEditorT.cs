///
///
/// @copyright (c) by MEMPIC LTD
/// @copyright (c) by WWW.MEMPIC.COM
///
///
/// @license http://www.mempic.com/licenses/private
///
/// By exercising the licensed rights you accept and agree to be bound by the
/// terms and conditions of this @license. To the extent this @license
/// may be interpreted as a contract, you are granted the licensed rights
/// in consideration of your acceptance of these terms and conditions,
/// and the licensor grants you such rights in consideration of benefits
/// the licensor receives from making the licensed material available
/// under these terms and conditions.
///
///
using PathCreation;

namespace PathCreationEditor
{
  public abstract class PathEditor<T> : PathEditor where T: PathCreator
  {
    public virtual T pathCreator => target as T;
    public virtual VertexPath path => pathCreator.path;

    protected abstract void OnPathUpdated();

    protected virtual void OnEnable()
    {
      Subscribe();
    }

    protected virtual void OnDisable()
    {
      Unsubscribe();
    }

    private void Subscribe()
    {
      pathCreator.pathUpdated += OnPathUpdated;
    }

    private void Unsubscribe()
    {
      pathCreator.pathUpdated -= OnPathUpdated;
    }
  }
}
