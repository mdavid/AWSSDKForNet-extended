/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;

using Amazon.ElasticMapReduce;
using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Interface for accessing AmazonElasticMapReduce.
    ///  
    ///  <para> This is the <i>Amazon Elastic MapReduce API Reference</i> . This guide provides descriptions and samples of the Amazon Elastic
    /// MapReduce APIs.</para> <para>Amazon Elastic MapReduce is a web service that makes it easy to process large amounts of data efficiently.
    /// Elastic MapReduce uses Hadoop processing combined with several AWS products to do tasks such as web indexing, data mining, log file
    /// analysis, machine learning, scientific simulation, and data warehousing.</para>
    /// </summary>
    public interface AmazonElasticMapReduce : IDisposable
    {
        

         /// <summary>
         /// <para>AddInstanceGroups adds an instance group to a running cluster.</para>
         /// </summary>
         /// 
         /// <param name="addInstanceGroupsRequest">Container for the necessary parameters to execute the AddInstanceGroups service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <returns>The response from the AddInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest); 

         /// <summary>
         /// <para> AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed in each job flow. </para> <para>If your job
         /// flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data. You can bypass
         /// the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries directly to the
         /// software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to Add More than 256 Steps to a Job
         /// Flow in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para> A step specifies the location of a JAR file stored either on
         /// the master node of the job flow or in Amazon S3. Each step is performed by the main function of the main class of the JAR file. The main
         /// class can be specified either in the manifest of the JAR or by using the MainFunction parameter of the step. </para> <para> Elastic
         /// MapReduce executes each step in the order listed. For a step to be considered complete, the main function must exit with a zero exit code
         /// and all Hadoop jobs started while the step was running must have completed and run successfully. </para> <para> You can only add steps to a
         /// job flow that is in one of the following states: STARTING, BOOTSTRAPPING, RUNNING, or WAITING.</para>
         /// </summary>
         /// 
         /// <param name="addJobFlowStepsRequest">Container for the necessary parameters to execute the AddJobFlowSteps service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest); 

         /// <summary>
         /// <para> TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any step not yet completed is canceled and the EC2
         /// instances on which the job flow is running are stopped. Any log files not already saved are uploaded to Amazon S3 if a LogUri was specified
         /// when the job flow was created. </para>
         /// </summary>
         /// 
         /// <param name="terminateJobFlowsRequest">Container for the necessary parameters to execute the TerminateJobFlows service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest); 

         /// <summary>
         /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
         /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
         /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
         /// following criteria are returned:</para>
         /// <ul>
         /// <li>Job flows created and completed in the last two weeks</li>
         /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
         /// <c>WAITING</c> ,
         /// <c>SHUTTING_DOWN</c> ,
         /// 
         /// <c>STARTING</c> </li>
         /// 
         /// </ul>
         /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
         /// </summary>
         /// 
         /// <param name="describeJobFlowsRequest">Container for the necessary parameters to execute the DescribeJobFlows service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest); 

         /// <summary>
         /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
         /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
         /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
         /// following criteria are returned:</para>
         /// <ul>
         /// <li>Job flows created and completed in the last two weeks</li>
         /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
         /// <c>WAITING</c> ,
         /// <c>SHUTTING_DOWN</c> ,
         /// 
         /// <c>STARTING</c> </li>
         /// 
         /// </ul>
         /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        DescribeJobFlowsResponse DescribeJobFlows();

         /// <summary>
         /// <para> SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster cannot be terminated by user intervention, an
         /// API call, or in the event of a job-flow error. The cluster still terminates upon successful completion of the job flow. Calling
         /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination API on all of the EC2 instances in a
         /// cluster.</para> <para> SetTerminationProtection is used to prevent accidental termination of a job flow and to ensure that in the event of
         /// an error, the instances will persist so you can recover any data stored in their ephemeral instance storage.</para> <para> To terminate a
         /// job flow that has been locked by setting SetTerminationProtection to <c>true</c> ,
         /// you must first unlock the job flow by a subsequent call to SetTerminationProtection in which you set the value to <c>false</c> .
         /// </para> <para> For more information, go to Protecting a Job Flow from Termination in the <i>Amazon Elastic MapReduce Developer's Guide.</i>
         /// </para>
         /// </summary>
         /// 
         /// <param name="setTerminationProtectionRequest">Container for the necessary parameters to execute the SetTerminationProtection service method
         ///           on AmazonElasticMapReduce.</param>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest); 

         /// <summary>
         /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
         /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
         /// Amazon S3. If the JobFlowInstancesDetail <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
         /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
         /// JobFlowInstancesDetail <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
         /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
         /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
         /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
         /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to Add More than
         /// 256 Steps to a Job Flow in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend
         /// that you periodically store your results.</para>
         /// </summary>
         /// 
         /// <param name="runJobFlowRequest">Container for the necessary parameters to execute the RunJobFlow service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <returns>The response from the RunJobFlow service method, as returned by AmazonElasticMapReduce.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        RunJobFlowResponse RunJobFlow(RunJobFlowRequest runJobFlowRequest); 

         /// <summary>
         /// <para>ModifyInstanceGroups modifies the number of nodes and configuration settings of an instance group. The input parameters include the
         /// new target instance count for the group and the instance group ID. The call will either succeed or fail atomically.</para>
         /// </summary>
         /// 
         /// <param name="modifyInstanceGroupsRequest">Container for the necessary parameters to execute the ModifyInstanceGroups service method on
         ///           AmazonElasticMapReduce.</param>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest); 
    }
}
    
