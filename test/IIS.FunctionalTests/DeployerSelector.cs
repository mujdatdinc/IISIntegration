// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Server.IISIntegration.FunctionalTests
{
    public static class DeployerSelector
    {
        public static ServerType ServerType => ServerType.IIS;

        public static ApplicationDeployer GetDeployer(DeploymentParameters deploymentParameters, ILoggerFactory loggerFactory)
        {
            return new IISDeployer(deploymentParameters, loggerFactory);
        }
    }
}