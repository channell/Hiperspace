# Hiperspace.Rocks
RocksDB is a remarkable technology, originally developed by Google (LevelDB) and optimized by Facebook for 
absolutely lowest possible latency writing to SSD devices.
RocksDB used Log-structured-Merge (LSM) to stream updates while maintaining fast key access.  
It is used both as a key/value database, and also as a driver for relational-databases, message-stores, 
blockchain and various analytical services.  The use of LSM optimizes performance and life of SSD devices.

Hiperspace.Rocks uses RockDB to store elements in durable SSD memory 
