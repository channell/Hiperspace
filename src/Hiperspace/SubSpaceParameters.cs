// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Security.Principal;

namespace Hiperspace
{
    /// <summary>
    /// Represents the traits of a subspace, including filters, versioning, and security labels.
    /// </summary>
    /// <remarks>
    /// Provides a generic initialisation of the subspace when dynamically Instantiated.   
    /// </remarks> 
    public struct SubSpaceParameters
    {
        /// <summary>
        /// The HiperSpace that provides storage services to this SubSpace
        /// </summary>
        public HiperSpace Space;
        /// <summary>
        /// Horizon filters for the subspace <see cref="Horizon"/>
        /// </summary>
        public Horizon[]? Horizon;
        /// <summary>
        /// The version of the subspace, used to determine if the subspace is up to date
        /// </summary>
        public DateTime? AsAt;
        /// <summary>
        /// The delta from which the subspace was created, used to determine if the subspace is up to date
        /// </summary>
        public DateTime? DeltaFrom;
        /// <summary>
        /// Label applied to the subspace for security verification in Horizon filters
        /// </summary>
        public string? ContextLabel;
        /// <summary>
        /// Label applied to the subspace for fine grained access control
        /// </summary>
        public IPrincipal? UserLabel;
        /// <summary>
        /// Was the subspace opened by a remote client, and need to have Horizon security re-applied 
        /// </summary>
        public bool RemoteLabel;

        /// <summary>
        /// Gets or sets the service provider used to resolve application services.
        /// </summary>
        public IServiceProvider? ServiceProvider;

        /// <summary>
        /// Associates the specified <see cref="HiperSpace"/> with the current <see cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="space">The <see cref="HiperSpace"/> to associate with this instance. Cannot be null.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the specified <see cref="HiperSpace"/> associated.</returns>
        public SubSpaceParameters WithHiperSpace (HiperSpace space)
        {
            Space = space;
            return this;
        }

        /// <summary>
        /// Merges the specified horizons with the existing horizons and returns the updated <see
        /// cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="horizon">An array of <see cref="Horizon"/> objects to be merged with the current horizons.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the updated horizons.</returns>
        public SubSpaceParameters WithHorizon(Horizon[] horizon)
        {
            Horizon = Horizon?.Union(horizon).ToArray() ?? horizon;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="AsAt"/> property to the specified date and time.
        /// </summary>
        /// <param name="asAt">The date and time to set as the current context for this instance.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> with the updated <see cref="AsAt"/> value.</returns>
        public SubSpaceParameters WithAsAt(DateTime asAt)
        {
            AsAt = asAt;
            return this;
        }

        /// <summary>
        /// Sets the starting point for delta calculations and returns the updated <see cref="SubSpaceParameters"/>
        /// instance.
        /// </summary>
        /// <param name="deltaFrom">The <see cref="DateTime"/> value representing the starting point for delta calculations.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the specified delta starting point.</returns>
        public SubSpaceParameters WithDeltaFrom(DateTime deltaFrom)
        {
            DeltaFrom = deltaFrom;
            return this;
        }

        /// <summary>
        /// Sets the context label for the current <see cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="contextLabel">The context label to assign. Cannot be null.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the updated context label.</returns>
        public SubSpaceParameters WithContextLabel(string contextLabel)
        {
            ContextLabel = contextLabel;
            return this;
        }

        /// <summary>
        /// Sets the user label for the current <see cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="userLabel">The user label to associate with this instance. Cannot be null.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the updated user label.</returns>
        public SubSpaceParameters WithUserLabel(IPrincipal userLabel)
        {
            UserLabel = userLabel;
            return this;
        }

        /// <summary>
        /// Sets the remote label flag and returns the updated <see cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="remoteLabel">A <see langword="bool"/> indicating whether the remote label should be enabled.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the updated remote label setting.</returns>
        public SubSpaceParameters WithRemoteLabel(bool remoteLabel)
        {
            RemoteLabel = remoteLabel;
            return this;
        }
        /// <summary>
        /// Sets the service provider and returns the updated <see cref="SubSpaceParameters"/> instance.
        /// </summary>
        /// <param name="services">The <see cref="IServiceProvider"/> to associate with this instance.</param>
        /// <returns>Copy of the current <see cref="SubSpaceParameters"/> instance with the updated service provider.</returns>
        public SubSpaceParameters WithServiceProvider(IServiceProvider services)
        {
            ServiceProvider = services;
            return this;
        }
    }
}