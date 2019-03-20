/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class OperateBatchDomainRequest : RpcAcsRequest<OperateBatchDomainResponse>
    {
        public OperateBatchDomainRequest()
            : base("Alidns", "2015-01-09", "OperateBatchDomain", "alidns", "openAPI")
        {
        }

		private string userClientIp;

		private List<DomainRecordInfo> domainRecordInfos;

		private string lang;

		private string type;

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public List<DomainRecordInfo> DomainRecordInfos
		{
			get
			{
				return domainRecordInfos;
			}

			set
			{
				domainRecordInfos = value;
				for (int i = 0; i < domainRecordInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Rr", domainRecordInfos[i].Rr);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Line", domainRecordInfos[i].Line);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Domain", domainRecordInfos[i].Domain);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Type", domainRecordInfos[i].Type);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Priority", domainRecordInfos[i].Priority);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Value", domainRecordInfos[i].Value);
					DictionaryUtil.Add(QueryParameters,"DomainRecordInfo." + (i + 1) + ".Ttl", domainRecordInfos[i].Ttl);
				}
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public class DomainRecordInfo
		{

			private string rr;

			private string line;

			private string domain;

			private string type;

			private int? priority;

			private string value_;

			private int? ttl;

			public string Rr
			{
				get
				{
					return rr;
				}
				set	
				{
					rr = value;
				}
			}

			public string Line
			{
				get
				{
					return line;
				}
				set	
				{
					line = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public int? Ttl
			{
				get
				{
					return ttl;
				}
				set	
				{
					ttl = value;
				}
			}
		}

        public override OperateBatchDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OperateBatchDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
