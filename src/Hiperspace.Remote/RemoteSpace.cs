using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using Hiperspace.Meta;
#pragma warning disable CS8425 // Async-iterator member has one or more parameters of type 'CancellationToken' but none of them is decorated with the 'EnumeratorCancellation' attribute, so the cancellation token parameter from the generated 'IAsyncEnumerable<>.GetAsyncEnumerator' will be unconsumed

namespace Hiperspace.Remote
{
    public class RemoteSpace : HiperSpace
    {
        private GrpcChannel _channel;
        private RemoteServer.RemoteServerClient _service;

        private string _name;
        private MetaModel? _model;
        private string _address;
        private string _realm;
        private string _user;
        private Token? _sessionToken;
        private Guid _token;
        private bool _read;
        public RemoteSpace(string name, MetaModel? model, string address, string realm, string user, Guid token, bool read = false)
        {
            _channel = GrpcChannel.ForAddress(address);
            _service = new RemoteServer.RemoteServerClient(_channel);
            _name = name;
            _model = model;
            _address = address;
            _realm = realm;
            _user = user;
            _token = token;
            _read = read;

            Open();
        }

        private void Open ()
        {
            try
            {
                _sessionToken =
                    _service
                    .Open(new OpenRequest
                    {
                        Token = new Token
                        {
                            TokenId = ByteString.CopyFrom(_token.ToByteArray())
                        },
                        Path = _name,
                        MetaModel = (_model != null) switch
                        {
                            true => ByteString.CopyFrom(_model.Bytes),
                            false => ByteString.CopyFrom(Array.Empty<byte>())
                        },
                        Read = _read,
                        UserName = _user,
                    });
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source = null)
        {
            try
            {
                var result =
                    _service
                    .Bind(
                        new BindRequest
                        {
                            Key = ByteString.CopyFrom(key),
                            Value = ByteString.CopyFrom(value),
                            Token = _sessionToken
                        });
                switch (result.State)
                {
                    case ResponseState.Ok: return Result.Ok(result.Content.ToArray());
                    case ResponseState.Skip: return Result.Skip(result.Content.ToArray());
                    default: return Result.Fail(result.Content.ToArray());
                }
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Bind (key, value, source);

                    case StatusCode.DataLoss:
                        throw new IOException (ex.Message);

                    case StatusCode.Internal:
                        throw new Exception (ex.Message);
                }
                throw;
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            try
            {
                var result =
                    _service
                    .BindVersion(
                        new BindVersionRequest
                        {
                            Key = ByteString.CopyFrom(key),
                            Value = ByteString.CopyFrom(value),
                            Version = Timestamp.FromDateTime(version.ToUniversalTime()),
                            Token = _sessionToken
                        });
                switch (result.State)
                {
                    case ResponseState.Ok: return Result.Ok(result.Content.ToArray());
                    case ResponseState.Skip: return Result.Skip(result.Content.ToArray());
                    default: return Result.Fail(result.Content.ToArray());
                }
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Bind(key, value, version, source);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            try
            {
                var result =
                    _service
                    .BindVersion(
                        new BindVersionRequest
                        {
                            Key = ByteString.CopyFrom(key),
                            Value = ByteString.CopyFrom(value),
                            Version = Timestamp.FromDateTime(version.ToUniversalTime()),
                            Token = _sessionToken
                        });
                switch (result.State)
                {
                    case ResponseState.Ok: return Result.Ok(result.Content.ToArray());
                    case ResponseState.Skip: return Result.Skip(result.Content.ToArray());
                    default: return Result.Fail(result.Content.ToArray());
                }
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Bind(key, value, version, source);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source = null)
        {
            try
            {
                var result = await
                    _service
                    .BindAsync(
                        new BindRequest
                        {
                            Key = ByteString.CopyFrom(key),
                            Value = ByteString.CopyFrom(value),
                            Token = _sessionToken
                        });
                switch (result.State)
                {
                    case ResponseState.Ok: return Result.Ok(result.Content.ToArray());
                    case ResponseState.Skip: return Result.Skip(result.Content.ToArray());
                    default: return Result.Fail(result.Content.ToArray());
                }
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await BindAsync(key, value, source);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            try
            {
                var result = await
                    _service
                    .BindVersionAsync(
                        new BindVersionRequest
                        {
                            Key = ByteString.CopyFrom(key),
                            Value = ByteString.CopyFrom(value),
                            Version = Timestamp.FromDateTime(version.ToUniversalTime()),
                            Token = _sessionToken
                        });
                switch (result.State)
                {
                    case ResponseState.Ok: return Result.Ok(result.Content.ToArray());
                    case ResponseState.Skip: return Result.Skip(result.Content.ToArray());
                    default: return Result.Fail(result.Content.ToArray());
                }
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await BindAsync(key, value, version, source);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, object? source)[] batch)
        {
            try
            {
                var request = new BatchBindRequest { Token = _sessionToken };
                for (int c = 0; c < batch.Length; c++)
                {
                    request.Value.Add(new BindRequest
                    {
                        Key = ByteString.CopyFrom(batch[c].key),
                        Value = ByteString.CopyFrom(batch[c].value)
                    });
                }
                var result =
                    _service
                    .BatchBind(request);

                return result
                    .Content
                    .Select(r => r.State switch
                    {
                        ResponseState.Ok => Result.Ok((r.Key.ToArray(), r.Value.ToArray())),
                        ResponseState.Skip => Result.Skip((r.Key.ToArray(), r.Value.ToArray())),
                        _ => Result.Fail((r.Key.ToArray(), r.Value.ToArray()))
                    })
                    .ToArray();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return BatchBind(batch);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            try
            {
                var request = new BatchBindVersionRequest { Token = _sessionToken };
                for (int c = 0; c < batch.Length; c++)
                {
                    request.Value.Add(new BindVersionRequest
                    {
                        Key = ByteString.CopyFrom(batch[c].key),
                        Value = ByteString.CopyFrom(batch[c].value),
                        Version = Timestamp.FromDateTime(batch[c].version.ToUniversalTime())
                    });
                }
                var result =
                    _service
                    .BatchVersionBind(request);

                return result
                    .Content
                    .Select(r => r.State switch
                    {
                        ResponseState.Ok => Result.Ok((r.Key.ToArray(), r.Value.ToArray())),
                        ResponseState.Skip => Result.Skip((r.Key.ToArray(), r.Value.ToArray())),
                        _ => Result.Fail((r.Key.ToArray(), r.Value.ToArray()))
                    })
                    .ToArray();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return BatchBind(batch);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, object? source)[] batch)
        {
            try
            {
                var request = new BatchBindRequest { Token = _sessionToken };
                for (int c = 0; c < batch.Length; c++)
                {
                    request.Value.Add(new BindRequest
                    {
                        Key = ByteString.CopyFrom(batch[c].key),
                        Value = ByteString.CopyFrom(batch[c].value)
                    });
                }
                var result = await
                    _service
                    .BatchBindAsync(request);

                return result
                    .Content
                    .Select(r => r.State switch
                    {
                        ResponseState.Ok => Result.Ok((r.Key.ToArray(), r.Value.ToArray())),
                        ResponseState.Skip => Result.Skip((r.Key.ToArray(), r.Value.ToArray())),
                        _ => Result.Fail((r.Key.ToArray(), r.Value.ToArray()))
                    })
                    .ToArray();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await BatchBindAsync(batch);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            try
            {
                var request = new BatchBindVersionRequest { Token = _sessionToken };
                for (int c = 0; c < batch.Length; c++)
                {
                    request.Value.Add(new BindVersionRequest
                    {
                        Key = ByteString.CopyFrom(batch[c].key),
                        Value = ByteString.CopyFrom(batch[c].value),
                        Version = Timestamp.FromDateTime(batch[c].version.ToUniversalTime())
                    });
                }
                var result = await
                    _service
                    .BatchVersionBindAsync(request);

                return result
                    .Content
                    .Select(r => r.State switch
                    {
                        ResponseState.Ok => Result.Ok((r.Key.ToArray(), r.Value.ToArray())),
                        ResponseState.Skip => Result.Skip((r.Key.ToArray(), r.Value.ToArray())),
                        _ => Result.Fail((r.Key.ToArray(), r.Value.ToArray()))
                    })
                    .ToArray();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await BatchBindAsync(batch);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> Find(byte[] begin, byte[] end)
        {
            try
            {
                var result =
                    _service
                    .Find(
                        new FindRequest
                        {
                            Begin = ByteString.CopyFrom(begin),
                            End = ByteString.CopyFrom(end),
                            Token = _sessionToken
                        });
                return result.Content.Select(r => (r.Key.ToArray(), r.Value.ToArray()));
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Find (begin, end);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                var result =
                    _service
                    .FindVersion(
                        new FindVersionRequest
                        {
                            Begin = ByteString.CopyFrom(begin),
                            End = ByteString.CopyFrom(end),
                            Version = version.HasValue
                                      ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                                      : null,
                            Token = _sessionToken
                        });
                return result.Content.Select(r => (r.Key.ToArray(), r.Version.ToDateTime().ToUniversalTime(), r.Value.ToArray()));
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Find(begin, end, version);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            var result = await 
            _service
            .FindAsync(
                new FindRequest
                {
                    Begin = ByteString.CopyFrom(begin),
                    End = ByteString.CopyFrom(end),
                    Token = _sessionToken
                });

            foreach (var r in result.Content)
            {
                yield return (r.Key.ToArray(), r.Value.ToArray());
            }
        }

        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            var result = await
                _service
                .FindVersionAsync(
                    new FindVersionRequest
                    {
                        Begin = ByteString.CopyFrom(begin),
                        End = ByteString.CopyFrom(end),
                        Version = version.HasValue
                                    ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                                    : null,
                        Token = _sessionToken
                    });
            foreach (var r in result.Content)
            {
                yield return (r.Key.ToArray(), r.Version.ToDateTime().ToUniversalTime(), r.Value.ToArray());
            }
        }

        public override byte[] Get(byte[] key)
        {
            try
            {
                var result = _service.Get(new KeyRequest
                {
                    Key = ByteString.CopyFrom(key),
                    Token = _sessionToken
                });
                return result.Content.ToArray();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Get(key);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override (byte[] Value, DateTime version) Get(byte[] key, DateTime? version)
        {
            try
            {
                var result = _service.GetVersion(new KeyVersionRequest
                {
                    Key = ByteString.CopyFrom(key),
                    Version = version.HasValue
                                      ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                                      : null,
                    Token = _sessionToken
                });
                if (result != null)
                    return (result.Content.ToArray(), result.Version.ToDateTime().ToUniversalTime());
                else
                    return (Array.Empty<byte>(), new DateTime().ToUniversalTime());
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return Get(key, version);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async Task<byte[]> GetAsync(byte[] key)
        {
            try
            {
                var result = await _service.GetAsync(new KeyRequest
                {
                    Key = ByteString.CopyFrom(key),
                    Token = _sessionToken
                });
                if (result != null)
                    return result.Content.ToArray();
                else
                    return Array.Empty<byte>();
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await GetAsync(key);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async Task<(byte[] Value, DateTime version)> GetAsync(byte[] key, DateTime? version)
        {
            try
            {
                var result = await _service.GetVersionAsync(new KeyVersionRequest
                {
                    Key = ByteString.CopyFrom(key),
                    Version = version.HasValue
                              ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                              : null,
                    Token = _sessionToken
                });
                if (result != null)
                    return (result.Content.ToArray(), result.Version.ToDateTime().ToUniversalTime());
                else
                    return (Array.Empty<byte>(), new DateTime().ToUniversalTime());
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return await GetAsync(key, version);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            try
            {
                var result = _service.GetVersions(new KeyRequest
                {
                    Key = ByteString.CopyFrom(key),
                    Token = _sessionToken
                });
                return result.Content.Select(r => (r.Content.ToByteArray(), r.Version.ToDateTime().ToUniversalTime()));
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return GetVersions(key);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }

        public override async IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            var result = await _service.GetVersionsAsync(new KeyRequest
            {
                Key = ByteString.CopyFrom(key),
                Token = _sessionToken
            });
            foreach (var r in result.Content)
            {
                yield return (r.Content.ToByteArray(), r.Version.ToDateTime().ToUniversalTime());
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            try
            {
                var result =
                    _service
                    .FindIndex(
                        new FindRequest
                        {
                            Begin = ByteString.CopyFrom(begin),
                            End = ByteString.CopyFrom(end),
                            Token = _sessionToken
                        });
                return result.Content.Select(r => (r.Key.ToArray(), r.Value.ToArray()));
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return FindIndex(begin,end);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                var result =
                    _service
                    .FindIndexVersion(
                        new FindVersionRequest
                        {
                            Begin = ByteString.CopyFrom(begin),
                            End = ByteString.CopyFrom(end),
                            Version = version.HasValue
                                      ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                                      : null,
                            Token = _sessionToken
                        });
                return result.Content.Select(r => (r.Key.ToArray(), r.Version.ToDateTime().ToUniversalTime(), r.Value.ToArray()));
            }
            catch (RpcException ex)
            {
                switch (ex.StatusCode)
                {
                    case StatusCode.FailedPrecondition:
                        Open();
                        return FindIndex(begin, end, version);

                    case StatusCode.DataLoss:
                        throw new IOException(ex.Message);

                    case StatusCode.Internal:
                        throw new Exception(ex.Message);
                }
                throw;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            var result = await
                _service
                .FindIndexAsync(
                    new FindRequest
                    {
                        Begin = ByteString.CopyFrom(begin),
                        End = ByteString.CopyFrom(end),
                        Token = _sessionToken
                    });
            foreach (var r in result.Content)
            {
                yield return (r.Key.ToArray(), r.Value.ToArray());
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            var result = await
                _service
                .FindIndexVersionAsync(
                    new FindVersionRequest
                    {
                        Begin = ByteString.CopyFrom(begin),
                        End = ByteString.CopyFrom(end),
                        Version = version.HasValue
                                    ? Timestamp.FromDateTime(version.Value.ToUniversalTime())
                                    : null,
                        Token = _sessionToken
                    });
            foreach (var r in result.Content)
            {
                yield return (r.Key.ToArray(), r.Version.ToDateTime().ToUniversalTime(), r.Value.ToArray());
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> Space()
        {
            throw new NotImplementedException();
        }

        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> SpaceAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _service.Close(_sessionToken);
                }
                _disposedValue = true;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
#warning add imple
            throw new NotImplementedException();
        }
    }
}
#pragma warning restore CS8425 // Async-iterator member has one or more parameters of type 'CancellationToken' but none of them is decorated with the 'EnumeratorCancellation' attribute, so the cancellation token parameter from the generated 'IAsyncEnumerable<>.GetAsyncEnumerator' will be unconsumed
