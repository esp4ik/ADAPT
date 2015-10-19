﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *******************************************************************************/

using System;
using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel
{
    public class OperationData
    {
        public OperationData()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; private set; }

        public int LoggedDataId { get; set; }

        public int? ImplementConfigurationId { get; set; }

        public int? MachineConfigurationId { get; set; }

        public List<int> ConnetorIds { get; set; }

        public int? LoadId { get; set; }

        public OperationType OperationType { get; set; }

        public int? PrescriptionId { get; set; }

        public int? ProductId { get; set; }

        public int? VarietyLocatorId { get; set; }

        public int? WorkItemOperationId { get; set; }

        public int MaxDepth { get; set; }

        public Func<IEnumerable<SpatialRecord>> GetSpatialRecords { get; set; }

        public Func<IEnumerable<Section>> GetSections { get; set; }
 
        public int SpatialRecordCount { get; set; }
    }
}
