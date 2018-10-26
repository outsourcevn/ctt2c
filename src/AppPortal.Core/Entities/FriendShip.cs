using System;

namespace AppPortal.Core.Entities
{
    public class FriendShip : BaseEntity<string>
    {
        public FriendShip() => Id = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string FriendId { get; set; }
        public FriendShipStatus FriendShipStatus { get; set; }
    }

    public enum FriendShipStatus : int
    {
        isFollowed,
        isFriended,
        isGrouped
    }
}
