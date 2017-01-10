//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public PositionComponent position { get { return (PositionComponent)GetComponent(CoreComponentIds.Position); } }
        public bool hasPosition { get { return HasComponent(CoreComponentIds.Position); } }

        public Entity AddPosition(int newX, int newY) {
            var component = CreateComponent<PositionComponent>(CoreComponentIds.Position);
            component.x = newX;
            component.y = newY;
            return AddComponent(CoreComponentIds.Position, component);
        }

        public Entity ReplacePosition(int newX, int newY) {
            var component = CreateComponent<PositionComponent>(CoreComponentIds.Position);
            component.x = newX;
            component.y = newY;
            ReplaceComponent(CoreComponentIds.Position, component);
            return this;
        }

        public Entity RemovePosition() {
            return RemoveComponent(CoreComponentIds.Position);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherPosition;

        public static IMatcher Position {
            get {
                if(_matcherPosition == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Position);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherPosition = matcher;
                }

                return _matcherPosition;
            }
        }
    }
