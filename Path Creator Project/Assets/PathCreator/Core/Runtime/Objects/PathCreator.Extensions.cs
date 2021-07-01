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
using System;

namespace PathCreation
{
  public static class PathCreatorExtensions
  {
    public static void EncapsulatePath(this PathCreator pathCreator, PathCreator other)
    {
      pathCreator.bezierPath.EncapsulatePath(other);
      pathCreator.EditorData.VertexPathSettingsChanged();
    }
  }
}
