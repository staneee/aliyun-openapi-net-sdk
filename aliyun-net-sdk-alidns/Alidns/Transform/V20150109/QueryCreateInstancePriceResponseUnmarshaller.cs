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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class QueryCreateInstancePriceResponseUnmarshaller
    {
        public static QueryCreateInstancePriceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCreateInstancePriceResponse queryCreateInstancePriceResponse = new QueryCreateInstancePriceResponse();

			queryCreateInstancePriceResponse.HttpResponse = context.HttpResponse;
			queryCreateInstancePriceResponse.RequestId = context.StringValue("QueryCreateInstancePrice.RequestId");
			queryCreateInstancePriceResponse.Origin = context.StringValue("QueryCreateInstancePrice.Origin");
			queryCreateInstancePriceResponse.Discount = context.StringValue("QueryCreateInstancePrice.Discount");
			queryCreateInstancePriceResponse.Amount = context.StringValue("QueryCreateInstancePrice.Amount");
			queryCreateInstancePriceResponse.Currency = context.StringValue("QueryCreateInstancePrice.Currency");

			List<QueryCreateInstancePriceResponse.QueryCreateInstancePrice_Rule> queryCreateInstancePriceResponse_rules = new List<QueryCreateInstancePriceResponse.QueryCreateInstancePrice_Rule>();
			for (int i = 0; i < context.Length("QueryCreateInstancePrice.Rules.Length"); i++) {
				QueryCreateInstancePriceResponse.QueryCreateInstancePrice_Rule rule = new QueryCreateInstancePriceResponse.QueryCreateInstancePrice_Rule();
				rule.RuleId = context.LongValue("QueryCreateInstancePrice.Rules["+ i +"].RuleId");
				rule.Name = context.StringValue("QueryCreateInstancePrice.Rules["+ i +"].Name");
				rule.Title = context.StringValue("QueryCreateInstancePrice.Rules["+ i +"].Title");

				queryCreateInstancePriceResponse_rules.Add(rule);
			}
			queryCreateInstancePriceResponse.Rules = queryCreateInstancePriceResponse_rules;
        
			return queryCreateInstancePriceResponse;
        }
    }
}
