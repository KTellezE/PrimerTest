// <summary>
// <copyright file="UserDto.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.Users.Common.DTOs.Responses.Users
{
    /// <summary>
    /// UserDto class.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        /// <value>
        /// int Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>
        /// string Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        /// <value>
        /// string UserName.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        /// <value>
        /// string Email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Active.
        /// </summary>
        /// <value>
        /// bool Active.
        /// </value>
        public bool Active { get; set; }

    }
}