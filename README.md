# Hiperspace
Hiperspace is an Object technology that uses a key-addressable store to expand an application data-model beyond the limits of memory. 
that can be directly referenced in main memory. 

Elements are not duplicated or changed to match database shapes.  
Elements are serialized directly using `Protocol Buffers` to and from key/value structure for storage in memory stores including CXL
expanded and pooled memory, shared cache, local SSD or key-value durable databases.  
Elements that are not currently being used are released from main memory, and transparently (and quickly) reloaded when referenced. 
Memory stores allow petabytes of data to be addressed.

All Hiperspace objects are immutable, but versioning provides the experience of mutability without the cache-coherency that would require constant server lookup.

[Sparx UML documentation](https://channell.github.io/Hiperspace/doc/)
