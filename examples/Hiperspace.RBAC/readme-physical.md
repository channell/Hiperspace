# readme
```mermaid
classDiagram
    class Note {
        # owner  : Access.RBAC.Realm
        + Text  : String
    }
    class Edge2 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Edge3 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Edge4 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class RefGroup {
        + Value  : Access.RBAC.Group
    }
    RefGroup --> Access.RBAC.Group
    class Graph.Route {
        # Name  : String
        + Rules  : HashSet~Graph.Rule~
    }
    Graph.Route *-- Graph.Rule
    class Graph.Rule {
        # FromType  : String
        # ToType  : String
        # EdgeType  : String
    }
    class Access.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    Access.PathMessage *-- Graph.Route
    Access.PathMessage *-- String
    Access.PathMessage *-- Graph.HiperEdge
    class Access.RBAC.PermissionType {
        Create = 1
        Delete = 2
        Update = 3
        CreateDelete = 4
        CreateUpdate = 5
        DeleteUpdate = 6
        All = 7
    }
    class Access.RBAC.Realm {
        # Name  : String
        + Author  : Access.RBAC.User
        + Valid  = ((((Name == null) || (Author == null)) || (CanCreate == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + Exists (Name = Name) : Access.RBAC.Realm
        + TypeName () = "RBAC-Realm"
        + CanCreate () = (((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)
        + ErrorMsg () = ((((empty(Exists) == false) ? "Realm Exists, " : "") + ((Author == null) ? "Invalid Author, " : "")) + ((CanCreate == false) ? "not authorised " : ""))
        + Note () : Note
    }
    Access.RBAC.Realm --> Access.RBAC.User
    Access.RBAC.Realm o-- Note
    class Access.RBAC.Permission {
        # owner  : Any
        # Item  : Access.RBAC.Resource
        # Right  : Access.RBAC.PermissionType
        + Approval  : HashSet~RefGroup~
        + Required  : HashSet~RefGroup~
        + Approved  : Boolean
        + Valid  : Boolean
        + Author  : Access.RBAC.User
        + Deleted  : Boolean
        + TypeName  : String
        + Subject  : String
        + Authorised  : Boolean
        + CanUpdate  : Boolean
        + CanDelete  : Boolean
        + ErrorMsg  : String
        + ValidAuthor  : Boolean
        + ErrorAuthor  : String
    }
    Access.RBAC.Permission --> Access.RBAC.Resource
    Access.RBAC.Permission --> Access.RBAC.PermissionType
    Access.RBAC.Permission *-- RefGroup
    Access.RBAC.Permission *-- RefGroup
    Access.RBAC.Permission --> Access.RBAC.User
    class Access.RBAC.Group {
        # Realm  : Access.RBAC.Realm
        # Id  : Guid
        + Deleted  = false
        + Author  : Access.RBAC.User
        + Name  : String
        + Parent  : Access.RBAC.Group
        + Root  = ((Parent == null) ? true : false)
        + Valid  = (((((Id == null) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + Permission () : Access.RBAC.GroupPermission
        + Roles () : Access.RBAC.GroupRole
        + ValidBase () = ((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)
        + ErrorBase () = ((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))
        + SubGroups (Parent = this) : Access.RBAC.Group
        + Members (Group = this) : Access.RBAC.User
        + Exists (Realm = Realm, Name = Name) : Access.RBAC.Group
        + TypeName () = "RBAC-Group"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == true) && (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == false)) ? false : true)
        + CanCreate () = (((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((Id == null) ? "Invalid Id, " : "") + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.Group --> Access.RBAC.Realm
    Access.RBAC.Group --> Access.RBAC.User
    Access.RBAC.Group o-- Access.RBAC.GroupPermission
    Access.RBAC.Group o-- Access.RBAC.GroupRole
    Access.RBAC.Group ..|> Edge2
    Access.RBAC.Group ..|> Edge3
    Access.RBAC.Group ..|> Edge4
    class Access.RBAC.User {
        # Realm  : Access.RBAC.Realm
        # Id  : Guid
        + Name  : String
        + Author  : Access.RBAC.User
        + Deleted  = false
        + PublicKey  : String
        + Group  : Access.RBAC.Group
        + Valid  = ((((((Id == null) || (PublicKey == null)) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + Permission () : Access.RBAC.UserPermission
        + Roles () : Access.RBAC.UserRole
        + ValidBase () = ((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)
        + ErrorBase () = ((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + Exists (Realm = Realm, Name = Name) : Access.RBAC.User
        + TypeName () = "RBAC-User"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + CanCreate () = (((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)
        + ErrorMsg () = ((((((Id == null) ? "Invalid Id, " : "") + ((PublicKey == null) ? "Missing PublicKey, " : "")) + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.User --> Access.RBAC.Realm
    Access.RBAC.User --> Access.RBAC.Group
    Access.RBAC.User o-- Access.RBAC.UserPermission
    Access.RBAC.User o-- Access.RBAC.UserRole
    Access.RBAC.User ..|> Edge2
    class Access.RBAC.Role {
        # Realm  : Access.RBAC.Realm
        # Code  : String
        + Deleted  = false
        + Author  : Access.RBAC.User
        + Name  : String
        + Valid  = (((((Code == null) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + Permission () : Access.RBAC.RolePermission
        + Roles () : Access.RBAC.RoleRole
        + ValidBase () = ((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)
        + ErrorBase () = ((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))
        + Exists (Realm = Realm, Name = Name) : Access.RBAC.User
        + TypeName () = "RBAC-Role"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == true) && (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == false)) ? true : false)
        + CanCreate () = (((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((Code == null) ? "Invalid Code, " : "") + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.Role --> Access.RBAC.Realm
    Access.RBAC.Role --> Access.RBAC.User
    Access.RBAC.Role o-- Access.RBAC.RolePermission
    Access.RBAC.Role o-- Access.RBAC.RoleRole
    class Access.RBAC.RoleMember {
        # owner  : Any
        # Role  : Access.RBAC.Role
        + Deleted  : Boolean
        + Author  : Access.RBAC.User
        + Valid  : Boolean
        + ValidAuthor  : Boolean
        + ErrorAuthor  : String
        + TypeName  : String
        + CanUpdate  : Boolean
        + CanDelete  : Boolean
        + ErrorMsg  : String
    }
    Access.RBAC.RoleMember --> Access.RBAC.Role
    Access.RBAC.RoleMember --> Access.RBAC.User
    class Access.RBAC.Resource {
        # Subject  : String
        + Approvers  : HashSet~RefGroup~
        + Valid  = ((((((Subject == null) || (Approvers == null)) || (ValidAuthor == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + Author  : Access.RBAC.User
        + Deleted  = false
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,Subject)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,Subject) == true)) ? true : false)
        + ErrorMsg () = ((((((Subject == null) ? "Invalid Subject, " : "") + ((Approvers == null) ? "Invalid Approvers, " : "")) + ((ValidAuthor == false) ? "Invalid Author, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
    }
    Access.RBAC.Resource *-- RefGroup
    Access.RBAC.Resource --> Access.RBAC.User
    class Access.RBAC.RoleRole {
        # owner  : Access.RBAC.Role
        # Role  : Access.RBAC.Role
        + Deleted  = false
        + Author  : Access.RBAC.User
        + Valid  = (((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + TypeName () = "RBAC-Role-Member"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.RoleRole --> Access.RBAC.Role
    Access.RBAC.RoleRole --> Access.RBAC.User
    Access.RBAC.RoleRole ..> Access.RBAC.User
    Access.RBAC.RoleRole ..|> Access.RBAC.RoleMember
    class Access.RBAC.RolePermission {
        # owner  : Access.RBAC.Role
        # Item  : Access.RBAC.Resource
        # Right  : Access.RBAC.PermissionType
        + Approval  : HashSet~RefGroup~
        + Required  = Item?.Approvers
        + Approved  = approved(Approval,Required)
        + Valid  = (((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + Author  : Access.RBAC.User
        + Deleted  = false
        + TypeName () = "RBAC-Permission"
        + Subject () = Item?.Subject
        + Authorised () = authorised(Author,Right,Subject)
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
    }
    Access.RBAC.RolePermission --> Access.RBAC.Resource
    Access.RBAC.RolePermission --> Access.RBAC.PermissionType
    Access.RBAC.RolePermission *-- RefGroup
    Access.RBAC.RolePermission --> Access.RBAC.User
    Access.RBAC.RolePermission ..> Access.RBAC.User
    Access.RBAC.RolePermission ..|> Access.RBAC.Permission
    Access.RBAC.RolePermission ..|> Edge2
    class Access.RBAC.UserRole {
        # owner  : Access.RBAC.User
        # Role  : Access.RBAC.Role
        + Deleted  = false
        + Author  : Access.RBAC.User
        + Valid  = (((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + TypeName () = "RBAC-Role-Member"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.UserRole --> Access.RBAC.Role
    Access.RBAC.UserRole --> Access.RBAC.User
    Access.RBAC.UserRole ..> Access.RBAC.User
    Access.RBAC.UserRole ..|> Access.RBAC.RoleMember
    class Access.RBAC.UserPermission {
        # owner  : Access.RBAC.User
        # Item  : Access.RBAC.Resource
        # Right  : Access.RBAC.PermissionType
        + Approval  : HashSet~RefGroup~
        + Required  = Item?.Approvers
        + Approved  = approved(Approval,Required)
        + Valid  = (((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + Author  : Access.RBAC.User
        + Deleted  = false
        + TypeName () = "RBAC-Permission"
        + Subject () = Item?.Subject
        + Authorised () = authorised(Author,Right,Subject)
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
    }
    Access.RBAC.UserPermission --> Access.RBAC.Resource
    Access.RBAC.UserPermission --> Access.RBAC.PermissionType
    Access.RBAC.UserPermission *-- RefGroup
    Access.RBAC.UserPermission --> Access.RBAC.User
    Access.RBAC.UserPermission ..> Access.RBAC.User
    Access.RBAC.UserPermission ..|> Access.RBAC.Permission
    Access.RBAC.UserPermission ..|> Edge2
    class Access.RBAC.GroupRole {
        # owner  : Access.RBAC.Group
        # Role  : Access.RBAC.Role
        + Deleted  = false
        + Author  : Access.RBAC.User
        + Valid  = (((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
        + TypeName () = "RBAC-Role-Member"
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
    }
    Access.RBAC.GroupRole --> Access.RBAC.Role
    Access.RBAC.GroupRole --> Access.RBAC.User
    Access.RBAC.GroupRole ..> Access.RBAC.User
    Access.RBAC.GroupRole ..|> Access.RBAC.RoleMember
    class Access.RBAC.GroupPermission {
        # owner  : Access.RBAC.Group
        # Item  : Access.RBAC.Resource
        # Right  : Access.RBAC.PermissionType
        + Approval  : HashSet~RefGroup~
        + Required  = Item?.Approvers
        + Approved  = approved(Approval,Required)
        + Valid  = (((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)
        + Author  : Access.RBAC.User
        + Deleted  = false
        + TypeName () = "RBAC-Permission"
        + Subject () = Item?.Subject
        + Authorised () = authorised(Author,Right,Subject)
        + CanUpdate () = authorised(Author,Access.RBAC.PermissionType.Update,TypeName)
        + CanDelete () = (((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)
        + ErrorMsg () = (((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))
        + ValidAuthor () = ((Author == null) ? false : true)
        + ErrorAuthor () = ((ValidAuthor == false) ? "Missing user, " : "")
        + ByAuthor (Author = Author) : Access.RBAC.User
    }
    Access.RBAC.GroupPermission --> Access.RBAC.Resource
    Access.RBAC.GroupPermission --> Access.RBAC.PermissionType
    Access.RBAC.GroupPermission *-- RefGroup
    Access.RBAC.GroupPermission --> Access.RBAC.User
    Access.RBAC.GroupPermission ..> Access.RBAC.User
    Access.RBAC.GroupPermission ..|> Access.RBAC.Permission
    Access.RBAC.GroupPermission ..|> Edge2
```

---

## AspectImpl Note
 A Access realm is a mechanism used for protecting Web application resources. It gives you the ability to protect a resource with a defined Access constraint and then define the user roles that can access the protected resource.

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.Realm||||
|+|Text|String||||

---

## View Edge2


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Edge3


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Edge4


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Value RefGroup


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Access.RBAC.Group||||

---

## Value Graph.Route
Route across a graph of edge/node to form an HiperEdge

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
|+|Rules|HashSet<Graph.Rule>||||

---

## Value Graph.Rule
A rule for a route that matched as a type of Edge to a HiperEdge, e.g. { Name = 'relation', Rules = [{FromType = 'Person', ToType = 'Person', EdgeType = 'Mother'}]}

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|FromType|String||||
|#|ToType|String||||
|#|EdgeType|String||||

---

## Message Access.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## Enum Access.RBAC.PermissionType
Permission enum can be checked with a bitwise and

||Name|Type|*|@|=|
|-|-|-|-|-|-|
||Create|Int32|||1|
||Delete|Int32|||2|
||Update|Int32|||3|
||CreateDelete|Int32|||4|
||CreateUpdate|Int32|||5|
||DeleteUpdate|Int32|||6|
||All|Int32|||7|

---

## EntityImpl Access.RBAC.Realm
 A Access realm is a mechanism used for protecting Web application resources. It gives you the ability to protect a resource with a defined Access constraint and then define the user roles that can access the protected resource.

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
|+|Author|Access.RBAC.User||||
||Valid|Some(Boolean)| Validation constraint for the creation of a realm in hiperspace. ||((((Name == null) || (Author == null)) || (CanCreate == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
||Exists|Access.RBAC.Realm|||Name = Name|
||TypeName|Some(String)|||"RBAC-Realm"|
||CanCreate|Some(Boolean)| Can the user create this realm using permissions granted to them, their group or their role? ||(((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for when validation fails. ||((((empty(Exists) == false) ? "Realm Exists, " : "") + ((Author == null) ? "Invalid Author, " : "")) + ((CanCreate == false) ? "not authorised " : ""))|
|+|Note|Note||||

---

## View Access.RBAC.Permission
A permission granted to a group user or role on a resource, typically an entity in hiperspace database. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Item|Access.RBAC.Resource| Identify all the resource item. |||
|#|Right|Access.RBAC.PermissionType| The permission being granted create, update, delete. |||
|+|Approval|HashSet<RefGroup>| The set of roles that have approve this permission. |||
|+|Required|HashSet<RefGroup>| The set of roles that are required to approve this permission before it is used. |||
|+|Approved|Boolean| Flag for Horizon conditions to hide unapproved permission requests. |||
|+|Valid|Boolean| Validation criteria to implement standard constraint rules. |||
|+|Author|Access.RBAC.User||||
|+|Deleted|Boolean|Flag for read horizon filter to hide when true|||
|+|TypeName|String||||
|+|Subject|String||||
|+|Authorised|Boolean||||
|+|CanUpdate|Boolean| Property that applies a security check to see if the user can update this permission through user, group or role permission|||
|+|CanDelete|Boolean| Property that applies a security check to see if the user can deleet this permission through user, group or role permission|||
|+|ErrorMsg|String| Diagnostic error message for when the validation fails. |||
|+|ValidAuthor|Boolean||||
|+|ErrorAuthor|String||||

---

## EntityImpl Access.RBAC.Group
Group is a hierarchical organization of users or service accounts

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Realm|Access.RBAC.Realm||||
|#|Id|Guid||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Author|Access.RBAC.User||||
|+|Name|String||||
|+|Parent|Access.RBAC.Group| Referenced to the parent group of this group. |||
||Root|Some(Boolean)| Flag for searching to indicate whether this is a root group. ||((Parent == null) ? true : false)|
||Valid|Some(Boolean)| Validation criteria to implement constraints, used with Horizon filters. ||(((((Id == null) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
|+|Permission|Access.RBAC.GroupPermission| The set of permissions granted to this security principal, stored in the segment. |||
|+|Roles|Access.RBAC.GroupRole| Set of Roles that this security principle is a member of. |||
||ValidBase|Some(Boolean)| Base validation that is used by all implementations of this security principle. ||((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)|
||ErrorBase|Some(String)| Diagnostic error message for when the validation fails. ||((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))|
||SubGroups|Access.RBAC.Group| Join extension to all the children of this group. ||Parent = this|
||Members|Access.RBAC.User| Users that are members of this group. ||Group = this|
||Exists|Access.RBAC.Group|||Realm = Realm, Name = Name|
||TypeName|Some(String)|||"RBAC-Group"|
||CanUpdate|Some(Boolean)| Can the author update this group using permissions granted to itself, to its groups or to the role it's a member of? ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the author delete this group using its permissions? ||(((Deleted == true) && (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == false)) ? false : true)|
||CanCreate|Some(Boolean)| Can the author simulate deletion by hiding this item from the current view? ||(((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic property for validation failure. ||(((((Id == null) ? "Invalid Id, " : "") + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## EntityImpl Access.RBAC.User
User is a security principal that can connect to a resource. Either a person or a service account. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Realm|Access.RBAC.Realm||||
|#|Id|Guid||||
|+|Name|String||||
|+|Author|Access.RBAC.User||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|PublicKey|String||||
|+|Group|Access.RBAC.Group| Group that this user is a member of. |||
||Valid|Some(Boolean)| Validation criteria prior to creating this user in hyperspace. ||((((((Id == null) || (PublicKey == null)) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
|+|Permission|Access.RBAC.UserPermission| The set of permissions granted to this security principal, stored in the segment. |||
|+|Roles|Access.RBAC.UserRole| Set of Roles that this security principle is a member of. |||
||ValidBase|Some(Boolean)| Base validation that is used by all implementations of this security principle. ||((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)|
||ErrorBase|Some(String)| Diagnostic error message for when the validation fails. ||((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
||Exists|Access.RBAC.User|||Realm = Realm, Name = Name|
||TypeName|Some(String)|||"RBAC-User"|
||CanUpdate|Some(Boolean)| Can the author update this user using permissions assigned to itself, its group or role that is a member of. ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the user simulate deleting of the user by hiding it from the current view? ||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||CanCreate|Some(Boolean)| Can the author create a new user using permissions assigned to itself, its group or a role, but it is a member of. ||(((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error property for validation failures. ||((((((Id == null) ? "Invalid Id, " : "") + ((PublicKey == null) ? "Missing PublicKey, " : "")) + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## EntityImpl Access.RBAC.Role
Royal membership can be validated directly for groups and users but also applies to a collection of permissions. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Realm|Access.RBAC.Realm||||
|#|Code|String| Friendly name for his user enroll check. |||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Author|Access.RBAC.User||||
|+|Name|String||||
||Valid|Some(Boolean)| Validation criteria for implementation of constraints and to prevent unauthorized update. ||(((((Code == null) || (ValidBase == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
|+|Permission|Access.RBAC.RolePermission| The set of permissions granted to this security principal, stored in the segment. |||
|+|Roles|Access.RBAC.RoleRole| Set of Roles that this security principle is a member of. |||
||ValidBase|Some(Boolean)| Base validation that is used by all implementations of this security principle. ||((((Realm == null) || (Name == null)) || (ValidAuthor == false)) ? false : true)|
||ErrorBase|Some(String)| Diagnostic error message for when the validation fails. ||((((Realm == null) ? "Realm is null, " : "") + ((Name == null) ? "Name Is null, " : "")) + ((ValidAuthor == false) ? "Author invalid, " : ""))|
||Exists|Access.RBAC.User|||Realm = Realm, Name = Name|
||TypeName|Some(String)|||"RBAC-Role"|
||CanUpdate|Some(Boolean)| Can the author update this role using permissions granted to itself, its group or role that is a member of ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the author simulate deletion by hiding this role from the current view? ||(((Deleted == true) && (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == false)) ? true : false)|
||CanCreate|Some(Boolean)| Can the author create this role? ||(((empty(Exists) == true) && (authorised(Author,Access.RBAC.PermissionType.Create,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for validation failures. ||(((((Code == null) ? "Invalid Code, " : "") + ((ValidBase == false) ? ErrorBase : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## View Access.RBAC.RoleMember
Any security principal (group, user or role) can be a member of a role - it is stored Separately. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Role|Access.RBAC.Role| Reference to the role that this group user or role is a member of |||
|+|Deleted|Boolean|Flag for read horizon filter to hide when true|||
|+|Author|Access.RBAC.User||||
|+|Valid|Boolean| Validation criteria to implement standard constraints. |||
|+|ValidAuthor|Boolean||||
|+|ErrorAuthor|String||||
|+|TypeName|String||||
|+|CanUpdate|Boolean| Can the author update this role membership? |||
|+|CanDelete|Boolean| Can the author simulate deletion of this role membership by hiding it from the current view? |||
|+|ErrorMsg|String| Diagnostic error property for validation failures. |||

---

## EntityImpl Access.RBAC.Resource
A resource is a subject where permissions can be granted to create, update, delete, or a combination of all

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Subject|String||||
|+|Approvers|HashSet<RefGroup>| Set of groups that must approve this resource access. |||
||Valid|Some(Boolean)|Validation property to implement standard constraints. ||((((((Subject == null) || (Approvers == null)) || (ValidAuthor == false)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
|+|Author|Access.RBAC.User||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
||CanUpdate|Some(Boolean)| Can the author update this resource? ||authorised(Author,Access.RBAC.PermissionType.Update,Subject)|
||CanDelete|Some(Boolean)| Can the author simulate deletion of resource by hiding it from the current view? ||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,Subject) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for validation failures. ||((((((Subject == null) ? "Invalid Subject, " : "") + ((Approvers == null) ? "Invalid Approvers, " : "")) + ((ValidAuthor == false) ? "Invalid Author, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|

---

## SegmentImpl Access.RBAC.RoleRole
Royal membership can be validated directly for groups and users but also applies to a collection of permissions. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.Role||||
|#|Role|Access.RBAC.Role| Reference to the role that this group user or role is a member of |||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Author|Access.RBAC.User||||
||Valid|Some(Boolean)| Validation criteria to implement standard constraints. ||(((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
||TypeName|Some(String)|||"RBAC-Role-Member"|
||CanUpdate|Some(Boolean)| Can the author update this role membership? ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the author simulate deletion of this role membership by hiding it from the current view? ||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error property for validation failures. ||(((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## SegmentImpl Access.RBAC.RolePermission
Royal membership can be validated directly for groups and users but also applies to a collection of permissions. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.Role||||
|#|Item|Access.RBAC.Resource| Identify all the resource item. |||
|#|Right|Access.RBAC.PermissionType| The permission being granted create, update, delete. |||
|+|Approval|HashSet<RefGroup>| The set of roles that have approve this permission. |||
||Required|Some(HashSet<RefGroup>)| The set of roles that are required to approve this permission before it is used. ||Item?.Approvers|
||Approved|Some(Boolean)| Flag for Horizon conditions to hide unapproved permission requests. ||approved(Approval,Required)|
||Valid|Some(Boolean)| Validation criteria to implement standard constraint rules. ||(((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
|+|Author|Access.RBAC.User||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
||TypeName|Some(String)|||"RBAC-Permission"|
||Subject|Some(String)|||Item?.Subject|
||Authorised|Some(Boolean)|||authorised(Author,Right,Subject)|
||CanUpdate|Some(Boolean)| Property that applies a security check to see if the user can update this permission through user, group or role permission||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Property that applies a security check to see if the user can deleet this permission through user, group or role permission||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for when the validation fails. ||(((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|

---

## SegmentImpl Access.RBAC.UserRole
User is a security principal that can connect to a resource. Either a person or a service account. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.User||||
|#|Role|Access.RBAC.Role| Reference to the role that this group user or role is a member of |||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Author|Access.RBAC.User||||
||Valid|Some(Boolean)| Validation criteria to implement standard constraints. ||(((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
||TypeName|Some(String)|||"RBAC-Role-Member"|
||CanUpdate|Some(Boolean)| Can the author update this role membership? ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the author simulate deletion of this role membership by hiding it from the current view? ||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error property for validation failures. ||(((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## SegmentImpl Access.RBAC.UserPermission
User is a security principal that can connect to a resource. Either a person or a service account. 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.User||||
|#|Item|Access.RBAC.Resource| Identify all the resource item. |||
|#|Right|Access.RBAC.PermissionType| The permission being granted create, update, delete. |||
|+|Approval|HashSet<RefGroup>| The set of roles that have approve this permission. |||
||Required|Some(HashSet<RefGroup>)| The set of roles that are required to approve this permission before it is used. ||Item?.Approvers|
||Approved|Some(Boolean)| Flag for Horizon conditions to hide unapproved permission requests. ||approved(Approval,Required)|
||Valid|Some(Boolean)| Validation criteria to implement standard constraint rules. ||(((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
|+|Author|Access.RBAC.User||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
||TypeName|Some(String)|||"RBAC-Permission"|
||Subject|Some(String)|||Item?.Subject|
||Authorised|Some(Boolean)|||authorised(Author,Right,Subject)|
||CanUpdate|Some(Boolean)| Property that applies a security check to see if the user can update this permission through user, group or role permission||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Property that applies a security check to see if the user can deleet this permission through user, group or role permission||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for when the validation fails. ||(((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|

---

## SegmentImpl Access.RBAC.GroupRole
Group is a hierarchical organization of users or service accounts

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.Group||||
|#|Role|Access.RBAC.Role| Reference to the role that this group user or role is a member of |||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Author|Access.RBAC.User||||
||Valid|Some(Boolean)| Validation criteria to implement standard constraints. ||(((((owner == null) || (Role == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|
||TypeName|Some(String)|||"RBAC-Role-Member"|
||CanUpdate|Some(Boolean)| Can the author update this role membership? ||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Can the author simulate deletion of this role membership by hiding it from the current view? ||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error property for validation failures. ||(((((owner == null) ? "Invalid owner, " : "") + ((Role == null) ? "Invalid Role, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|

---

## SegmentImpl Access.RBAC.GroupPermission
Group is a hierarchical organization of users or service accounts

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Access.RBAC.Group||||
|#|Item|Access.RBAC.Resource| Identify all the resource item. |||
|#|Right|Access.RBAC.PermissionType| The permission being granted create, update, delete. |||
|+|Approval|HashSet<RefGroup>| The set of roles that have approve this permission. |||
||Required|Some(HashSet<RefGroup>)| The set of roles that are required to approve this permission before it is used. ||Item?.Approvers|
||Approved|Some(Boolean)| Flag for Horizon conditions to hide unapproved permission requests. ||approved(Approval,Required)|
||Valid|Some(Boolean)| Validation criteria to implement standard constraint rules. ||(((((owner == null) || (Item == null)) || (CanUpdate == false)) || (CanDelete == false)) ? false : true)|
|+|Author|Access.RBAC.User||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
||TypeName|Some(String)|||"RBAC-Permission"|
||Subject|Some(String)|||Item?.Subject|
||Authorised|Some(Boolean)|||authorised(Author,Right,Subject)|
||CanUpdate|Some(Boolean)| Property that applies a security check to see if the user can update this permission through user, group or role permission||authorised(Author,Access.RBAC.PermissionType.Update,TypeName)|
||CanDelete|Some(Boolean)| Property that applies a security check to see if the user can deleet this permission through user, group or role permission||(((Deleted == false) || (authorised(Author,Access.RBAC.PermissionType.Delete,TypeName) == true)) ? true : false)|
||ErrorMsg|Some(String)| Diagnostic error message for when the validation fails. ||(((((owner == null) ? "Inalid owner, " : "") + ((Item == null) ? "Invalid item, " : "")) + ((CanUpdate == false) ? "Can not update, " : "")) + ((CanDelete == false) ? "Can not delete, " : ""))|
||ValidAuthor|Some(Boolean)|||((Author == null) ? false : true)|
||ErrorAuthor|Some(String)|||((ValidAuthor == false) ? "Missing user, " : "")|
||ByAuthor|Access.RBAC.User| Index to permissioned entities ||Author = Author|

